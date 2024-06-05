using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RowVehiclePoolMVC.Common;
using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.Context;
using RowVehiclePoolMVC.ViewModels;
using RowVehiclePoolMVC.Services;
using Microsoft.Extensions.Configuration;
using RowVehiclePoolMVC.Utilities;

using static System.Net.Mime.MediaTypeNames;
using Org.BouncyCastle.Asn1.Ocsp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Identity.Web;
using Microsoft.Extensions.Logging;
//using Microsoft.Graph.Models;
//using Microsoft.Graph.Models;

namespace RowVehiclePoolMVC.Controllers
{
    public class VehicleRequisitionsController : Controller
    {
        private ISession _session;
        private readonly RvpAppContext _context;
//        private readonly RvpAppBudContext _appBudContext;
        private PageInfo _pageInfo;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration { get; }
        public UserInfo _userInfo { get; set; }
        private readonly IMailService _mailService;
        private readonly GraphServiceClient _graphServiceClient;
        private readonly MicrosoftIdentityConsentAndConditionalAccessHandler _consentHandler;
        private readonly ILogger<VehicleRequisitionsController> _logger;
        private string[]? _graphScopes;
        private ISectionAbbrFinder _sectionAbbrFinder;
        private RvpAppSecurityContext _rvpAppSecurityContext;

        public VehicleRequisitionsController(RvpAppContext context, 
            IHttpContextAccessor httpContextAccessor,
            RvpAppSecurityContext rvpAppSecurityContext,
            IMailService mailService,
            IConfiguration configuration,
            GraphServiceClient graphServiceClient,
            MicrosoftIdentityConsentAndConditionalAccessHandler consentHandler,
            ISectionAbbrFinder sectionAbbrFinder,
            ILogger<VehicleRequisitionsController> logger)
        {
            _logger = logger;
            _graphServiceClient = graphServiceClient;
            _consentHandler = consentHandler;
            _graphScopes = configuration.GetValue<string>("DownStreamApi:Scopes").Split(' ');
            _mailService = mailService;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _sectionAbbrFinder= sectionAbbrFinder;
            _rvpAppSecurityContext = rvpAppSecurityContext;
            _pageInfo = httpContextAccessor.HttpContext.Session.GetObjectFromJson<PageInfo>("PageInfo");//Request.HttpContext.Session.GetObjectFromJson<PageInfo>("PageInfo");
            if (_pageInfo == null)
            {
                _pageInfo = new PageInfo(_context);
                httpContextAccessor.HttpContext.Session.SetObjectAsJson("PageInfo", _pageInfo);
            }
            _configuration = configuration;
        }

        public ActionResult FilterJobFunctionList(string jobNum)
        {
            return PartialView("SelectJobFunction");
        }
        public ActionResult SelectJobFunction()
        {
            IEnumerable<FunctionSearch> functionSearch = null;
            var contextOptions = new DbContextOptionsBuilder<RvpAppAlltContext>()
               .UseSqlServer(_configuration.GetConnectionString("Allotments_ConnectionString"))
               .Options;
            using (var allotmentContext = new RvpAppAlltContext(contextOptions))
            {
                var query = allotmentContext.AllotDetail.Where(c => (c.Func.Trim() == "3000" || c.Func.Trim() == "3001" || c.Func.Trim() == "3150" || c.Func.Trim() == "3151")
                                            && (c.FuncType == "1" || c.FuncType == "2")).Select(c => new FunctionSearch { Job = c.JobNum, Function = c.Func, FAP = c.FapNum });
                if (query != null)
                    functionSearch = query.ToList();
            }
            return PartialView("_SelectJobFunction", functionSearch);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SelectJobFunction(string job, string function, string FAP)
        {
            if (!ModelState.IsValid)
                return PartialView("_SelectJobFunction");

            var functionSearch = new FunctionSearch { Job = job, Function = function, FAP = FAP };
            return RedirectToAction("RequestPoolVehicle", "VehicleRequisitions", functionSearch);
        }

        private string Me {
            get
            {
                return User.Identity.Name.Substring(User.Identity.Name.IndexOf('\\') + 1);
            }
        }
        // GET: VehicleRequisitions
        public async Task<IActionResult> ViewAllRequisitions()
        {
            var vehicleRequestVM = new VehicleRequestVM();
            vehicleRequestVM.VehicleRequisitions = await _context.VehicleRequisition.GroupJoin(_context.VehicleAssignment, c => c.VehReqNo, d => d.VehReqNo, (e, f) => new { e, f }).SelectMany(e => e.f.DefaultIfEmpty(),
                (f, g) => new VehicleRequisitionVM
                {
                    VehReqNo = f.e.VehReqNo,
                    AssignedTagNo = g.AssignTagNo,
                    Destination = f.e.Destination,
                    Duties = f.e.Duties,
                    EmailAddress = f.e.EmailAddress,
                    NoInParty = f.e.NoInParty,
                    ReqComments = f.e.ReqComments,
                    ReqJobNo = f.e.ReqJobNo,
                    ReqReturnDate = f.e.ReqReturnDate,
                    Requestor = f.e.Requestor,
                    VehReqDate = f.e.VehReqDate,
                    ReqDepartDate = f.e.ReqDepartDate,
                    ReqBudget= f.e.ReqBudget,
                    VehReqStatus = f.e.VehReqStatus,
                })
                .OrderByDescending(e => e.VehReqNo).Skip(_pageInfo.PageStart).Take(_pageInfo.ItemsPerPage).ToListAsync(); 
            var requestors = _context.VehicleRequisition.Select(c => new ItemList { Text = c.Requestor, Value = c.Requestor }).Distinct().OrderBy(c=>c.Text).ToList();
            vehicleRequestVM.Requestors = requestors;
            
            vehicleRequestVM.ReqFromDate = DateTime.Now.AddDays(-2);
            vehicleRequestVM.ReqToDate = DateTime.Now.AddDays(2);
            vehicleRequestVM.VehReqStatus = "Pending";
            LoadAssignmentDropDowns();
            return View(vehicleRequestVM);
        }
        [HttpPost]
        public async Task<IActionResult> ViewAllRequisitions(VehicleRequestVM vehicleRequest)
        {
            var query = _context.VehicleRequisition.GroupJoin(_context.VehicleAssignment,c=>c.VehReqNo,d=>d.VehReqNo,(e,f) => new {e,f}).SelectMany(e => e.f.DefaultIfEmpty(),
                (f,g) => new VehicleRequisitionVM
                {
                    VehReqNo = f.e.VehReqNo,
                    AssignedTagNo = g.AssignTagNo,
                    Destination = f.e.Destination,
                    Duties= f.e.Duties,
                    EmailAddress= f.e.EmailAddress,
                    NoInParty= f.e.NoInParty,
                    ReqComments= f.e.ReqComments,
                    ReqJobNo = f.e.ReqJobNo,
                    ReqReturnDate = f.e.ReqReturnDate,
                    Requestor = f.e.Requestor,
                    VehReqDate= f.e.VehReqDate,
                    ReqDepartDate= f.e.VehReqDate,
                    ReqBudget = f.e.ReqBudget,
                    VehReqStatus= f.e.VehReqStatus,
                })
                .OrderByDescending(e => e.VehReqNo).Skip(_pageInfo.PageStart).Take(_pageInfo.ItemsPerPage);
            if (vehicleRequest.FilterRequestor)
            {
                query = query.Where(c => c.Requestor == vehicleRequest.VehRequestor);
            }
            if (vehicleRequest.FilterStatus)
            {
                query = query.Where(c => c.VehReqStatus == vehicleRequest.VehReqStatus);
            }
            if (vehicleRequest.FilterRequestDate)
            {
                if (vehicleRequest.ReqFromDate != DateTime.MinValue)
                    query = query.Where(c => c.VehReqDate >= vehicleRequest.ReqFromDate );
                if (vehicleRequest.VehReqDate != DateTime.MinValue)
                    query = query.Where(c => c.VehReqDate <= vehicleRequest.ReqToDate);
            }
            var vehicleRequisitions = await query.ToListAsync();
            var vehicleRequestVM = new VehicleRequestVM
            {
                FilterRequestor = vehicleRequest.FilterRequestor,
                FilterStatus = vehicleRequest.FilterStatus,
                FilterRequestDate = vehicleRequest.FilterRequestDate,
                ReqToDate = vehicleRequest.ReqToDate,
                PageInfo = vehicleRequest.PageInfo,
                VehRequestor = vehicleRequest.VehRequestor,
                VehicleRequisitions = vehicleRequisitions,
            };
            LoadAssignmentDropDowns();
            return View(vehicleRequestVM);
        }

        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        private async Task<EmployeeInfoVM> GetEmployeeInfo(string userPrincipalName)
        {
            //var userPrinicalName = User.Identity.Name;
            EmployeeInfoVM employeeInfoVM = null;
            try
            {
                IGraphServiceUsersCollectionPage users = await _graphServiceClient.Users.Request()
                //var user = await _graphServiceClient.Users.Request()
                    .Filter("mail eq '" + userPrincipalName + "'" )
                    .WithAppOnly()
                    .Select(u => new
                    {
                        u.DisplayName,
                        u.Mail,
                        u.Id,
                        u.EmployeeId,
                        u.MobilePhone,
                        u.BusinessPhones,
                        u.Manager,
                        u.OnPremisesExtensionAttributes,
                        u.GivenName,
                        u.Surname,
                        u.Department,
                        u.OfficeLocation,
                        u.JobTitle
                    })
                    .GetAsync();

                if (users != null && users.Count > 0)
                //if (user != null )
                {
                    var user = users.FirstOrDefault();
                    employeeInfoVM = new EmployeeInfoVM() {
                        DivisionHeadEmail = user.OfficeLocation != null ? await GetDivisionHeadEmail(user.OfficeLocation) : "",
                        EmployeeNumber = user.EmployeeId,
                        FirstName = user.GivenName,
                        LastName = user.Surname,
                        SectionDesc = user.Department ?? "",
                        SectionId= user.Department != null ? _sectionAbbrFinder.Get(user.Department) ?? "" : "",
                        Budget = user.OnPremisesExtensionAttributes.ExtensionAttribute4 ?? "",
                        SectionManagerEmail = user.JobTitle == "Section Head" || string.IsNullOrEmpty(user.JobTitle) ? "" : await GetSectionHeadEmail(user.Department)
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message, ex);
                //Console.WriteLine(ex.ToString());
                throw;
            }
            return employeeInfoVM;
        }
 
        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        private async Task<string> GetDivisionHeadEmail(string division)
        {
            string  divHeadEmail = null;
            try
            {
                IGraphServiceUsersCollectionPage users = await _graphServiceClient.Users.Request()
                    .Filter("jobTitle eq 'division head'")
                    .WithAppOnly()
                    .Select(u => new { u.Mail, u.OfficeLocation })
                    .GetAsync();
                if(users != null && users.Count > 0)
                {
                    var user = users.Where(c => c.OfficeLocation == "Right of Way").FirstOrDefault();
                    if(user != null && user.Mail != null)
                    {
                        divHeadEmail = user.Mail;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return divHeadEmail;
        }
        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        private async Task<string> GetSectionHeadEmail(string section)
        {
            string secHeadEmail = null;
#if DEBUG
            section = "Right of Way Acquisitions";
#endif
            try
            {
                IGraphServiceUsersCollectionPage users = await _graphServiceClient.Users.Request()
                    .Filter("(jobTitle eq 'section head' or startsWith(jobTitle,'sec head')) and department eq '"+section+"'")
                    .WithAppOnly()
                    .Select(u => new { u.Mail, u.OfficeLocation })
                    .GetAsync();
                if (users != null && users.Count > 0)
                {
                    var user = users.Where(c => c.OfficeLocation == "Right of Way").FirstOrDefault();
                    if (user != null && user.Mail != null)
                    {
                        secHeadEmail = user.Mail;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return secHeadEmail;
        }
        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        // GET: VehicleRequisitions/GetMyRequests
        public async Task<IActionResult> ViewMyRequisitions()
        {
            //var userProfiles = await GetEmployeeInfo("jessica.sisk@ardot.gov");

            var userid = Utility.GetUserId(User.Identity.Name);
            var userInfo = Utility.GetUserInfo(userid);
            var query = _context.VehicleRequisition.Where(c => c.Userid == userInfo.UserId).OrderByDescending(c => c.VehReqDate).Skip(_pageInfo.PageStart).Take(_pageInfo.ItemsPerPage);
            return View(await query.ToListAsync());
        }
        // GET: VehicleRequisitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleRequisition = await _context.VehicleRequisition
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleRequisition == null)
            {
                return NotFound();
            }

            return View(vehicleRequisition);
        }

        public async Task<IActionResult> DeleteRequestors()
        {
            var recentRequestors = _context.VehicleAssignment.Join(_context.VehicleRequisition, a => a.VehReqNo, b => b.VehReqNo, (a, b) => new {a,b})
                .Where(a => a.a.AssignReturnDate > DateTime.Now).Select( c => new DeleteRequestorVM { 
                    lname = c.b.Requestor.Substring(c.b.Requestor.IndexOf(' ') + 1),
                    fname = c.b.Requestor.Substring(0,c.b.Requestor.IndexOf(' ')),
                    Requestor= c.b.Requestor,
                    selected = false
                }).Distinct().ToList();

            var allRequestors = _context.VehicleRequisition
            .Distinct().Select(c => new DeleteRequestorVM
            {
                selected = true,
                lname = c.Requestor.Substring(c.Requestor.IndexOf(' ') + 1),
                fname = c.Requestor.Substring(0, c.Requestor.IndexOf(' ')),
                Requestor = c.Requestor,
            }).Distinct().ToList();
            
            var oldRequestors = allRequestors.Except(recentRequestors, new RecentRequisitionComparer()).OrderBy(c => c.lname);

            return View(oldRequestors.ToList());
        }

        [HttpPost]
        //public async Task<IActionResult> DeleteAssignments(DeleteRequestorVM assignedAssignments)
        public async Task<IActionResult> DeleteAssignments(IList<DeleteRequestorVM> assignedAssignments)
        {
            List<VehicleRequisition> vehicleRequisitions = new List<VehicleRequisition>();
            List<VehicleAssignment> vehicleAssignments = new List<VehicleAssignment>();
            foreach(var assignment in assignedAssignments)
            {
                vehicleRequisitions.AddRange(_context.VehicleRequisition.Where(c => c.Requestor == assignment.Requestor));
            }
            foreach(var vehicleRequisition in vehicleRequisitions)
            {
                vehicleAssignments.AddRange(_context.VehicleAssignment.Where(c => c.VehReqNo == vehicleRequisition.VehReqNo));
            }
            _context.VehicleAssignment.RemoveRange((IEnumerable<VehicleAssignment>)vehicleAssignments);
            _context.VehicleRequisition.RemoveRange((IEnumerable<VehicleRequisition>)vehicleRequisitions);
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }
        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://DC-11");

            return "LDAP://DC-11,";
        }

        [HttpPost]
        public JsonResult returnJobFunction(FunctionSearch functionSearch)
        {
            return Json(functionSearch);
        }

        private string GetEmployeeNumber(string userId)
        {
            string result = null;
            UserInfo userInfo = null;
            try
            {
                //If you are not sure about username and password, leave below 2 variables as it is
                String username = "AHTD\\LDAP";        //Change to your username, if you have any
                String passwd = "LDAPsearch";           //Change to your Password, if you have any


                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry("LDAP://AHTD.com/OU=Employees,OU=Users,OU=ARDOT,DC=AHTD,DC=com", username, passwd, AuthenticationTypes.None);

                ds = new DirectorySearcher(entry, "(&(sAMaccountname=" + Me + "))");
                //ds = new DirectorySearcher(entry, "(&(objectCategory=User)(objectClass=person))");

                ds.PropertiesToLoad.Add("extensionAttribute6");
                // Below statement will list all entries immediately below your BaseDN
                var results = ds.FindAll();

                foreach (System.DirectoryServices.SearchResult sr in results)
                {
                    result = sr.Properties["extensionAttribute6"].Count > 0 ? sr.Properties["extensionAttribute6"][0].ToString() : null;
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return result;
        }
        [HttpGet]
        public async Task<IActionResult> RequestPoolVehicle()
        {
            LoadRequisitionDropDowns();
            //EmployeeInfoVM emp = await GetEmployeeInfo();
            var vehicleRequest = new VehicleRequestVM()
            {
                ReqDepartDate = DateTime.Now,
                ReqReturnDate = DateTime.Now.AddHours(8)
            };
            return View(vehicleRequest);
        }

        // POST: VehicleRequisitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestPoolVehicle([Bind("VehReqDate,RequestFirstName, RequestLastName,VehType,Destination,Duties,NoInParty,ReqBudget,ReqFunction,ReqJobNo,ReqFap,ReqComments,ReqDepartDate,ReqDepartTime,ReqReturnDate,ReqReturnTime,VehReqStatus,NotificationDivHead,NotificationMan,EmailAddress,LastChangeUserid")] VehicleRequestVM vehicleRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employeeId = Utility.GetUserId(vehicleRequest.EmailAddress);
                    //if(userid == null)
                    //{
                    //    return View(vehicleRequest);
                    //}
                    var lastChangeUserId = Utility.GetUserId(User.Identity.Name);
                    var userInfo = Utility.GetUserInfo(employeeId);
                    var vehReqNo = await _context.VehicleRequisition.MaxAsync(c => c.VehReqNo) + 1;
                    EmployeeInfoVM employeeInfo = await GetEmployeeInfo(vehicleRequest.EmailAddress);// Utility.GetEmployeeInfo(userInfo.EmployeeNumber, _context);
                    var returnDate = vehicleRequest.ReqReturnDate.Date.Add(TimeSpan.Parse(vehicleRequest.ReqReturnTime));
                    var departDate = vehicleRequest.ReqDepartDate.Date.Add(TimeSpan.Parse(vehicleRequest.ReqDepartTime));
                    var vehicleRequisition = new VehicleRequisition()
                    {
                        VehReqNo = vehReqNo,
                        Destination = vehicleRequest.Destination,
                        Duties = vehicleRequest.Duties,
                        EmailAddress = vehicleRequest.EmailAddress,
                        LastChangeDate = DateTime.Now,
                        LastChangeUserid = lastChangeUserId,
                        NoInParty = vehicleRequest.NoInParty,
                        NotificationDivHead = employeeInfo.DivisionHeadEmail ?? "",
                        NotificationMan = employeeInfo.SectionManagerEmail ?? "",
                        ReqBudget = vehicleRequest.ReqBudget,
                        ReqComments = vehicleRequest.ReqComments ?? "",
                        ReqDepartDate = vehicleRequest.ReqDepartDate.Date.Add(TimeSpan.Parse(vehicleRequest.ReqDepartTime)),
                        ReqReturnDate = vehicleRequest.ReqReturnDate.Date.Add(TimeSpan.Parse(vehicleRequest.ReqReturnTime)),
                        ReqDivision = GetDivision(),
                        ReqFap = vehicleRequest.ReqFap ?? "",
                        ReqFunction = vehicleRequest.ReqFunction ?? "",
                        ReqJobNo = vehicleRequest.ReqJobNo ?? "",
                        ReqSectionId = employeeInfo.SectionId ?? "",
                        Requestor = vehicleRequest.RequestFirstName + " " + vehicleRequest.RequestLastName,
                        Userid = employeeId,
                        VehReqDate = DateTime.Now,
                        VehReqStatus = "P",
                        VehType = vehicleRequest.VehType ?? "car",
                    };
                    try
                    {
                        _context.Add(vehicleRequisition);
                        await _context.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        _logger.Log(LogLevel.Error ,ex.Message);
                    }
                    var dhnf = employeeInfo.DivisionHeadEmail != "Not Found" ? false : true;
                    var smnf = employeeInfo.SectionManagerEmail != "Not Found" ? false : true;
                    var mailRequest = new MailRequest()
                    {
                        Attachments = null,
                        Body = CreateRequestEmailMessage(vehicleRequisition, dhnf, smnf),
                        Subject = vehicleRequisition.Requestor + " has requested a vehicle",
                        From = vehicleRequest.EmailAddress,
                        To = GetEmailRecipients(),
                    };
#if DEBUG
mailRequest.To = "richard.harris@ardot.gov";
#endif
                    //send to approvers
                    try
                    {
                        await _mailService.SendEmailAsync(mailRequest);
                    }
                    catch (Exception ex)
                    {
                        _logger.Log(LogLevel.Error, "Email Failed - " + ex.Message);
                    }

                    //send to Section Head
                    if (!smnf)
                    {
                        mailRequest.To = employeeInfo.SectionManagerEmail;
#if DEBUG
mailRequest.To = "richard.harris@ardot.gov";
#endif
                        try
                        {
                            await _mailService.SendEmailAsync(mailRequest);
                        }
                        catch (Exception ex)
                        {
                            _logger.Log(LogLevel.Error, "Email Failed - " + ex.Message);
                        }
                    }

                    return RedirectToAction("VehicleRequestSaved", new { vehReqNo = vehReqNo });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            LoadRequisitionDropDowns();
            return View(vehicleRequest);
        }

        private void LoadRequisitionDropDowns()
        {
            List<string> budgetList = null;
            var contextOptions = new DbContextOptionsBuilder<RvpAppBudContext>()
                .UseSqlServer(_configuration.GetConnectionString("BudgetInfo_ConnectionString"))
                .Options;

            using (var budContext = new RvpAppBudContext(contextOptions))
            {
                budgetList = budContext.T101BudgetInf.Where(c => c.PayrEndDate == null && c.PahrBudget == "Y").Select(c => c.Budget)?.ToList();
            }

            ViewBag.Budget = budgetList;
            ViewBag.VehicleType = new List<string>() { "Car", "Pickup" };
            ViewBag.RequestStatuses = new List<ItemList>() {new ItemList{Value="P",Text = "Pending" }
                                ,new ItemList{Value="C", Text="Cancelled" }, new ItemList{Value="A",Text="Assigned" } };
            ViewBag.TimeOfDayVals = new List<SelectListItem>()
            {
                 new SelectListItem(){Text="Early",   Value="07:29:00"}
                ,new SelectListItem(){Text="7:30 AM", Value="07:30:00"}
                ,new SelectListItem(){Text="8:00 AM", Value="08:00:00"}
                ,new SelectListItem(){Text="8:30 AM", Value="08:30:00"}
                ,new SelectListItem(){Text="9:00 AM", Value="09:00:00"}
                ,new SelectListItem(){Text="9:30 AM", Value="09:30:00"}
                ,new SelectListItem(){Text="10:00 AM",Value="10:00:00"}
                ,new SelectListItem(){Text="10:30 AM",Value="10:30:00"}
                ,new SelectListItem(){Text="11:00 AM",Value="11:00:00"}
                ,new SelectListItem(){Text="11:30 AM",Value="11:30:00"}
                ,new SelectListItem(){Text="12:00 PM",Value="12:00:00"}
                ,new SelectListItem(){Text="12:30 PM",Value="12:30:00"}
                ,new SelectListItem(){Text="1:00 PM",Value="13:00:00"}
                ,new SelectListItem(){Text="1:30 PM",Value="13:30:00"}
                ,new SelectListItem(){Text="2:00 PM",Value="14:00:00"}
                ,new SelectListItem(){Text="2:30 PM",Value="14:30:00"}
                ,new SelectListItem(){Text="3:00 PM",Value="15:00:00"}
                ,new SelectListItem(){Text="3:30 PM",Value="15:30:00"}
                ,new SelectListItem(){Text="4:00 PM",Value="16:00:00"}
                ,new SelectListItem(){Text="4:30 PM",Value="16:30:00"}
                ,new SelectListItem(){Text="Late",Value="16:31:00"}
            };

        }

        public String GetEmailRecipients()
        {
            String returnString = null;
            try
            {
                var userIdList = _rvpAppSecurityContext.SystemSec.Where(c => c.ReceiveMail.ToUpper() == "Y" && c.SystemId == "WRVP").Select(c => c.Userid.Trim()).Distinct().ToList();
                if (userIdList != null && userIdList.Count > 0)
                {
                    foreach (var userId in userIdList)
                    {
                        returnString = returnString + Utility.GetEmailAddress(userId).Trim() + ";";
                    }
                    returnString = returnString.Substring(0, returnString.Length - 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail RecipientList Failed: {0}", ex.Message);
            }
            return returnString;
        }
        public IActionResult VehicleRequestSaved(int vehReqNo)
        {
            var requisition = _context.VehicleRequisition.Where(c=>c.VehReqNo== vehReqNo).FirstOrDefault();
            return View(requisition);
        }

        private string GetSessionId()
        {
            throw new NotImplementedException();
        }

        private string GetDivision()
        {
            return "RIGHT OF WAY";
        }

        [HttpGet]
        public async Task<IActionResult> AssignmentDetail(int requestId)
        {
            var assignmentDetailVM = new AssignmentDetailVM();
            var query = _context.VehicleRequisition.Where(c => c.VehReqNo == requestId);
            var requisition = await query.FirstOrDefaultAsync();
            assignmentDetailVM.VehicleRequisition = requisition;
            assignmentDetailVM.VehicleWeek = Utility.GetVehicleWeek(_context, requisition.ReqDepartDate.ToString("yyyyMMdd"));
            LoadAssignmentDropDowns();
            return View("AssignmentDetail", assignmentDetailVM);
        }
        //[Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IActionResult> VehicleAssign()
        {
            var assignmentSearch = new AssignmentSearchVM();
            var queryVal = _context.VehicleRequisition.GroupJoin(_context.VehicleAssignment, c => c.VehReqNo, d => d.VehReqNo,
                (c, d) => new { c, d }).SelectMany(f => f.d.DefaultIfEmpty(), (f, g) => new AssignmentDetail()
                {
                    VehReqNo = f.c.VehReqNo,
                    Destination = f.c.Destination,
                    Duties = f.c.Duties,
                    ReqBudget = f.c.ReqBudget,
                    NoInParty = (int)f.c.NoInParty,
                    ReqComments = f.c.ReqComments,
                    ReqDepartDate = f.c.ReqDepartDate,
                    ReqDivision = f.c.ReqDivision,
                    ReqReturnDate = f.c.ReqReturnDate,
                    VehReqDate = f.c.VehReqDate,
                    VehReqStatus = f.c.VehReqStatus,
                    Requestor = f.c.Requestor,
                    VehType = f.c.VehType,
                    AssignTagNo = g.AssignTagNo
                }).OrderByDescending(c => c.VehReqDate);


            assignmentSearch.Assignments = queryVal.Take(10).ToList();
            assignmentSearch.Page = 1;
            assignmentSearch.PageCount = (queryVal.Count() - 1) / 10;

            //assignmentSearch.Statuses = new List<SelectListItem>() {
            //    new SelectListItem() { Text = "Pending", Value = "P"},
            //    new SelectListItem() { Text = "Assigned", Value = "A"},
            //    new SelectListItem() { Text = "Cancelled", Value = "C" },
            //};

            //assignmentSearch.RequestorList = await _context.VehicleRequisition.Select(e => new SelectListItem()
            //{
            //    Text = VehicleRequisitionsController.GetRequestor(e.Requestor),
            //    Value = e.Requestor
            //}).Distinct().ToListAsync();
            //using (var budgetContext = new RvpAppBudContext())
            //{
            //    assignmentSearch.BudgetList = await budgetContext.T101BudgetInf.Where(c => c.PayrEndDate == null)
            //        .Select(d => new SelectListItem()
            //        {
            //            Text = d.Budget,
            //            Value = d.Budget
            //        }).ToListAsync();
            //}
            //if (assignmentSearch.BudgetList == null && assignmentSearch.BudgetList.Count > 0)
            //    HttpContext.Session.SetObjectAsJson("BudgetList", assignmentSearch.BudgetList);
            //else
            //{
            //    using (var budgetContext = new RvpAppBudContext())
            //    {
            //        assignmentSearch.BudgetList = await budgetContext.T101BudgetInf.Where(c => c.PahrBudget == "Y" && c.PayrEndDate == null)
            //            .Select(d => new SelectListItem()
            //            {
            //                Text = d.Budget,
            //                Value = d.Budget
            //            }).ToListAsync();
            //    }
            //}
            LoadDropDowns(assignmentSearch);
            HttpContext.Session.SetObjectAsJson("assignmentSearchVM", assignmentSearch);
            HttpContext.Session.SetObjectAsJson("assignmentQueryVal", queryVal);
            HttpContext.Session.SetObjectAsJson("RequestorList", assignmentSearch.RequestorList);

            return View(assignmentSearch);
        }

        [HttpGet]
        public IActionResult VehicleAssignments()
        {
            var assignments = HttpContext.Session.GetObjectFromJson<AssignmentDetail>("assignmentQueryVal");
            return PartialView("_vehicleAssignments", assignments);
        }
        private static string GetRequestor(string requestor)
        {
            var nameItems = requestor.Split(' ');
            if (nameItems.Length == 2)
            {
                return nameItems[1] + ", " + nameItems[0];
            }
            return requestor;
        }
        [HttpPost]
        public async Task<IActionResult> AssignmentSearch(AssignmentSearchVM assignmentSearch)
        {
            var queryVal = _context.VehicleRequisition.GroupJoin(_context.VehicleAssignment, c => c.VehReqNo, d => d.VehReqNo,
                (c, d) => new { c, d }).SelectMany(f => f.d.DefaultIfEmpty(), (f, g) => new AssignmentDetail()
                {
                    VehReqNo = f.c.VehReqNo,
                    Destination = f.c.Destination,
                    Duties = f.c.Duties,
                    ReqBudget = f.c.ReqBudget,
                    NoInParty = (int)f.c.NoInParty,
                    ReqComments = f.c.ReqComments,
                    ReqDepartDate = f.c.ReqDepartDate,
                    ReqDivision = f.c.ReqDivision,
                    ReqReturnDate = f.c.ReqReturnDate,
                    VehReqDate = f.c.VehReqDate,
                    VehReqStatus = f.c.VehReqStatus,
                    Requestor = f.c.Requestor,
                    VehType = f.c.VehType,
                    AssignTagNo = g.AssignTagNo
                });
            if (assignmentSearch.SearchBudget && !string.IsNullOrEmpty(assignmentSearch.ReqBudget))
                queryVal = queryVal.Where(c => c.ReqBudget.Equals(assignmentSearch.ReqBudget));
            if (assignmentSearch.SearchRequestor && !string.IsNullOrEmpty(assignmentSearch.Requestor))
                queryVal = queryVal.Where(c => c.Requestor.Equals(assignmentSearch.Requestor));
            if (assignmentSearch.SearchStatus && !string.IsNullOrEmpty(assignmentSearch.ReqStatus))
                queryVal = queryVal.Where(c => c.VehReqStatus.Equals(assignmentSearch.ReqStatus));
            if (assignmentSearch.SearchRequisitionDate)
            {
                var fromReqDate = new DateTime(assignmentSearch.FromReqDateYear, assignmentSearch.FromReqDateMonth, assignmentSearch.FromReqDateDay);
                if (fromReqDate != null)
                {
                    queryVal = queryVal.Where(c => c.ReqDepartDate >= fromReqDate);
                }
            }
            if (assignmentSearch.SearchRequisitionDate)
            {
                var toReqDate = new DateTime(assignmentSearch.ToReqDateYear, assignmentSearch.ToReqDateMonth, assignmentSearch.ToReqDateDay);
                if (toReqDate != null)
                {
                    queryVal = queryVal.Where(c => toReqDate >= c.VehReqDate);
                }
            }
            if (assignmentSearch.SearchAssignTagNumber && assignmentSearch.AssignTagNumber != null)
                queryVal = queryVal.Where(c => assignmentSearch.AssignTagNumber.Equals(c.AssignTagNo));

            assignmentSearch.Assignments = await queryVal.OrderByDescending(c => c.VehReqDate).Take(10).ToListAsync();

            assignmentSearch.Page = 1;
            assignmentSearch.PageCount = queryVal.Count() / 10;

            LoadDropDowns(assignmentSearch);
            HttpContext.Session.SetObjectAsJson("assignmentSearchVM", assignmentSearch);
            HttpContext.Session.SetObjectAsJson("assignmentQueryVal", queryVal);
            return View("VehicleAssign", assignmentSearch);
        }

        [HttpGet]
        public IActionResult ChangeAssignmentPage(int page, string pageLink)
        {
            var assignmentSearch = HttpContext.Session.GetObjectFromJson<AssignmentSearchVM>("assignmentSearchVM");
            var queryVal = HttpContext.Session.GetObjectFromJson<IList<AssignmentDetail>>("assignmentQueryVal");
            queryVal = queryVal.OrderByDescending(c => c.VehReqDate).ToList();
            switch (pageLink)
            {
                case ("first"):
                    page = 1;
                    break;
                case ("last"):
                    page = assignmentSearch.PageCount - 1;
                    break;
                case ("next"):
                    page++;
                    break;
                default:
                    page--;
                    break;
            }
            LoadDropDowns(assignmentSearch);
            assignmentSearch.Page = page;
            assignmentSearch.PageCount = (queryVal.Count() - 1) / 10;
            assignmentSearch.Assignments = queryVal.Skip((page - 1) * 10).Take(10).ToList();
            return View("VehicleAssign", assignmentSearch);
        }
        private void LoadDropDowns(AssignmentSearchVM assignmentSearch)
        {
            assignmentSearch.Statuses = new List<SelectListItem>() {
                new SelectListItem() { Text = "Pending", Value = "P"},
                new SelectListItem() { Text = "Assigned", Value = "A"},
                new SelectListItem() { Text = "Cancelled", Value = "C" },
            };

            assignmentSearch.RequestorList = _context.VehicleRequisition.Select(e => new SelectListItem()
            {
                Text = VehicleRequisitionsController.GetRequestor(e.Requestor),
                Value = e.Requestor
            }).Distinct().ToList();
            assignmentSearch.RequestorList = assignmentSearch.RequestorList.OrderBy(e => e.Text).ToList();

            var contextOptions = new DbContextOptionsBuilder<RvpAppBudContext>()
                .UseSqlServer(_configuration.GetConnectionString("BudgetInfo_ConnectionString"))
                .Options;

            using (var budContext = new RvpAppBudContext(contextOptions))
            {
                assignmentSearch.BudgetList = budContext.T101BudgetInf.Where(c => c.PahrBudget == "Y" && c.PayrEndDate == null)
                .Select(d => new SelectListItem()
                {
                    Text = d.Budget,
                    Value = d.Budget
                }).ToList();
            }
        }

        private void LoadAssignmentDropDowns()
        {
            ViewBag.Requestors = _context.VehicleRequisition.Select(c => new ItemList()
            {
                Text = c.Requestor,
                Value = c.Requestor
            }).Distinct().OrderBy(c=>c.Text).ToList();

            ViewBag.RequisitionStatuses = new List<SelectListItem>() {
                new SelectListItem() { Text = "Pending", Value = "P"},
                new SelectListItem() { Text = "Assigned", Value = "A"},
                new SelectListItem() { Text = "Cancelled", Value = "C" },
            };
            ViewBag.VehicleTypes = new List<SelectListItem>()
            {
                new SelectListItem(){ Text = "Pickup", Value = "Pickup"},
                new SelectListItem(){ Text = "Car", Value = "Car"}
            };
            ViewBag.TimeOfDayVals = new List<ItemList>()
            {
                 new ItemList(){Text="Early",   Value="07:29:00"}
                ,new ItemList(){Text="7:30 AM", Value="07:30:00"}
                ,new ItemList(){Text="8:00 AM", Value="08:00:00"}
                ,new ItemList(){Text="8:30 AM", Value="08:30:00"}
                ,new ItemList(){Text="9:00 AM", Value="09:00:00"}
                ,new ItemList(){Text="9:30 AM", Value="09:30:00"}
                ,new ItemList(){Text="10:00 AM",Value="10:00:00"}
                ,new ItemList(){Text="10:30 AM",Value="10:30:00"}
                ,new ItemList(){Text="11:00 AM",Value="11:00:00"}
                ,new ItemList(){Text="11:30 AM",Value="11:30:00"}
                ,new ItemList(){Text="12:00 PM",Value="12:00:00"}
                ,new ItemList(){Text="12:30 PM",Value="12:30:00"}
                ,new ItemList(){Text="1:00 PM",Value="13:00:00"}
                ,new ItemList(){Text="1:30 PM",Value="13:30:00"}
                ,new ItemList(){Text="2:00 PM",Value="14:00:00"}
                ,new ItemList(){Text="2:30 PM",Value="14:30:00"}
                ,new ItemList(){Text="3:00 PM",Value="15:00:00"}
                ,new ItemList(){Text="3:30 PM",Value="15:30:00"}
                ,new ItemList(){Text="4:00 PM",Value="16:00:00"}
                ,new ItemList(){Text="4:30 PM",Value="16:30:00"}
                ,new ItemList(){Text="Late",Value="16:31:00"}
            };
        }
        private IList<ItemList> GetTimeList() 
        {
            return new List<ItemList>()
            {
                 new ItemList() { Text = "Early"   ,Value = "07:29:00"}
                ,new ItemList() { Text = "7:30 AM" ,Value = "07:30:00"}
                ,new ItemList() { Text = "8:00 AM" ,Value = "08:00:00"}
                ,new ItemList() { Text = "8:30 AM" ,Value = "08:30:00"}
                ,new ItemList() { Text = "9:00 AM" ,Value = "09:00:00"}
                ,new ItemList() { Text = "9:30 AM" ,Value = "09:30:00"}
                ,new ItemList() { Text = "10:00 AM",Value = "10:00:00"}
                ,new ItemList() { Text = "10:30 AM",Value = "10:30:00"}
                ,new ItemList() { Text = "11:00 AM",Value = "11:00:00"}
                ,new ItemList() { Text = "11:30 AM",Value = "11:30:00"}
                ,new ItemList() { Text = "12:00 PM",Value = "12:00:00"}
                ,new ItemList() { Text = "12:30 PM",Value = "12:30:00"}
                ,new ItemList() { Text = "1:00 PM" ,Value = "13:00:00"}
                ,new ItemList() { Text = "1:30 PM" ,Value = "13:30:00"}
                ,new ItemList() { Text = "2:00 PM" ,Value = "14:00:00"}
                ,new ItemList() { Text = "2:30 PM" ,Value = "14:30:00"}
                ,new ItemList() { Text = "3:00 PM" ,Value = "15:00:00"}
                ,new ItemList() { Text = "3:30 PM" ,Value = "15:30:00"}
                ,new ItemList() { Text = "4:00 PM" ,Value = "16:00:00"}
                ,new ItemList() { Text = "4:30 PM" ,Value = "16:30:00"}
                ,new ItemList() { Text = "Late"    ,Value = "16:31:00"}
            };
        }
        // GET: VehicleRequisitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoadAssignmentDropDowns();

            var vehicleRequisition = await _context.VehicleRequisition.FindAsync(id);

            if (vehicleRequisition == null)
            {
                return NotFound();
            }
            var vehicleRequestVM = new VehicleRequestVM()
            {
                VehReqNo = vehicleRequisition.VehReqNo,
                Destination = vehicleRequisition.Destination,
                Duties = vehicleRequisition.Duties,
                EmailAddress = vehicleRequisition.EmailAddress,
                NoInParty = (int)vehicleRequisition.NoInParty,
                ReqBudget = vehicleRequisition.ReqBudget,
                ReqComments = vehicleRequisition.ReqComments,
                ReqDepartDate = vehicleRequisition.ReqDepartDate,
                ReqDepartTime = vehicleRequisition.ReqDepartDate.ToString("HH:mm:ss"),
                ReqFap = vehicleRequisition.ReqFap,
                ReqJobNo = vehicleRequisition.ReqJobNo,
                ReqReturnDate = vehicleRequisition.ReqReturnDate,
                ReqReturnTime = vehicleRequisition.ReqReturnDate.ToString("HH:mm:ss"),
                ReqFunction = vehicleRequisition.ReqFunction,
                RequestFirstName = vehicleRequisition.Requestor.Split(' ')[0],
                RequestLastName = vehicleRequisition.Requestor.Split(' ')[1],
                VehReqStatus= vehicleRequisition.VehReqStatus,
                VehType = vehicleRequisition.VehType,
                DepartTimeList = GetTimeList(),
                ReturnTimeList = GetTimeList(),
            };
            return View(vehicleRequestVM);
        }

        // POST: VehicleRequisitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you ; to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehReqNo,VehReqDate,RequestLastName,RequestFirstName,VehType,Destination,Duties,NoInParty,ReqBudget,ReqFunction,ReqJobNo,ReqFap,ReqComments,ReqDepartDate,ReqDepartTime,ReqReturnDate,ReqReturnTime,Userid,VehReqStatus,EmailAddress")] VehicleRequestVM vehicleRequest)
        {
            VehicleRequisition vehicleRequisition = null;
            if (id != vehicleRequest.VehReqNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    vehicleRequisition = _context.VehicleRequisition.Where(c=>c.VehReqNo == vehicleRequest.VehReqNo).FirstOrDefault();
                    if (vehicleRequisition != null)
                    {
                        vehicleRequisition.Requestor = !string.IsNullOrEmpty(vehicleRequest.RequestFirstName) && !string.IsNullOrEmpty(vehicleRequest.RequestLastName) ? vehicleRequest.RequestFirstName + " " + vehicleRequest.RequestLastName : vehicleRequisition.Requestor;
                        vehicleRequisition.Destination = vehicleRequest.Destination ?? vehicleRequisition.Destination;
                        vehicleRequisition.Duties = vehicleRequest.Duties ?? vehicleRequisition.Duties;
                        vehicleRequisition.EmailAddress = vehicleRequest.EmailAddress ?? vehicleRequisition.EmailAddress;
                        vehicleRequisition.LastChangeDate = DateTime.Now;
                        vehicleRequisition.LastChangeUserid = User.Identity.Name.Split('\\')[1];
                        vehicleRequisition.NoInParty = vehicleRequest.NoInParty;
                        vehicleRequisition.ReqBudget = vehicleRequest.ReqBudget ?? vehicleRequisition.ReqBudget;
                        vehicleRequisition.ReqComments = vehicleRequest.ReqComments ?? vehicleRequisition.ReqComments;
                        vehicleRequisition.ReqDepartDate = vehicleRequest.ReqDepartDate != DateTime.MinValue ? vehicleRequest.ReqDepartDate.Date + TimeSpan.Parse(vehicleRequest.ReqDepartTime) : vehicleRequisition.ReqDepartDate;
                        vehicleRequisition.ReqFap = vehicleRequest.ReqFap ?? vehicleRequisition.ReqFap;
                        vehicleRequisition.ReqFunction = vehicleRequest.ReqFunction ?? vehicleRequisition.ReqFunction;
                        vehicleRequisition.ReqJobNo = vehicleRequest.ReqJobNo ?? vehicleRequisition.ReqJobNo;
                        vehicleRequisition.ReqReturnDate = vehicleRequest.ReqReturnDate != DateTime.MinValue ? vehicleRequest.ReqReturnDate.Date + TimeSpan.Parse(vehicleRequest.ReqReturnTime) : vehicleRequisition.ReqReturnDate;
                        vehicleRequisition.VehReqStatus = vehicleRequest.VehReqStatus ?? vehicleRequisition.VehReqStatus;
                        vehicleRequisition.VehType = vehicleRequest.VehType ?? vehicleRequisition.VehType;

                        _context.Update(vehicleRequisition);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleRequisitionExists(vehicleRequest.VehReqNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ViewAllRequisitions));
            }
            return View(vehicleRequisition);
        }

        private string CreateRequestEmailMessage(VehicleRequisition request, bool dhnf, bool smnf)
        {
            string HTML = "<HTML>";
            HTML += "<HEAD>";
            HTML += "</HEAD>";
            HTML += "<BODY  bgcolor=\"lightyellow\">";
            if( dhnf )
            {
                HTML += "<h2 align=\"center\">No division head found for this employee</h2>";
            }
            if (dhnf)
            {
                HTML += "<h2 align=\"center\">No Section manager found for this employee</h2>";
            }
            HTML += "<TABLE cellpadding=\"4\">";
            HTML += "<tr><td>Vehicle Requisition Number: " + request.VehReqNo + "</tr></td>";
            HTML += "<TR><TD>";
            HTML += "Requestor: <A HREF=\"" + Url.Action("Assign", "VehicleAssignments") + "?vehreqno=" + request.VehReqNo + "\">";
            HTML += request.Requestor + "</A><br>Vehicle Type: " + request.VehType + "<br>Destination: " + request.Destination + "<br>Duties: " + request.Duties + "<br>Date: " + request.ReqDepartDate + " - " + request.ReqReturnDate + "</tr></td>";
            HTML += "<TR><TD>Budget: " + request.ReqBudget + "</td></tr>";
            HTML += "<TR><TD>Division: " + request.ReqDivision + "</td></tr>";
            HTML += "<TR><TD>Section: " + request.ReqSectionId + "</td></td>";
            HTML += "</TABLE>";
            HTML += "</BODY>";
            HTML += "</HTML>";
            return HTML;
        }

        // GET: VehicleRequisitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleRequisition = await _context.VehicleRequisition
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleRequisition == null)
            {
                return NotFound();
            }

            var query = _context.VehicleAssignment.Where(c => c.VehReqNo == vehicleRequisition.VehReqNo);
            string assignedTagNo = null;

            if (query != null)
                assignedTagNo = await query.Select(c => c.AssignTagNo).FirstOrDefaultAsync();

            VehicleRequestVM requestVM = new VehicleRequestVM()
            {
                VehRequestor = vehicleRequisition.Requestor,
                VehReqNo = vehicleRequisition.VehReqNo,
                Destination = vehicleRequisition.Destination,
                Duties = vehicleRequisition.Duties,
                EmailAddress = vehicleRequisition.EmailAddress,
                NoInParty = (int)vehicleRequisition.NoInParty,
                AssignedTagNo = assignedTagNo != null ? assignedTagNo : "",
                ReqDepartDate= vehicleRequisition.ReqDepartDate,
                ReqReturnDate= vehicleRequisition.ReqReturnDate,
                ReqBudget= vehicleRequisition.ReqBudget,
                ReqFap= vehicleRequisition.ReqFap,
                ReqComments= vehicleRequisition.ReqComments,
                NotificationDivHead= vehicleRequisition.NotificationDivHead,
                ReqSectionId= vehicleRequisition.ReqSectionId,
                VehType= vehicleRequisition.VehType,
                ReqJobNo= vehicleRequisition.ReqJobNo,
                ReqFunction = vehicleRequisition.ReqFunction,
            };
            return View(requestVM);
        }

        // POST: VehicleRequisitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            List<VehicleAssignment> vehicleAssignments = null;
            var query =  _context.VehicleAssignment.Where(c => c.VehReqNo == id);
            if (query.Count() == 0)
            {
                vehicleAssignments = await query.ToListAsync();
            }
            if (vehicleAssignments != null) 
            {
                _context.RemoveRange(vehicleAssignments);
            }
            var vehicleRequisition = await _context.VehicleRequisition.FindAsync(id);

            _context.VehicleRequisition.Remove(vehicleRequisition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index),"Home");
        }

        private bool VehicleRequisitionExists(int id)
        {
            return _context.VehicleRequisition.Any(e => e.VehReqNo == id);
        }
    }
}
