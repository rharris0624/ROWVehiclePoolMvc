using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RowVehiclePoolMVC.Context;
using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.ViewModels;
using RowVehiclePoolMVC.Utilities;
using Org.BouncyCastle.Asn1.Ocsp;
using RowVehiclePoolMVC.Services;

namespace RowVehiclePoolMVC.Controllers
{
    public class VehicleAssignmentsController : Controller
    {
        private readonly RvpAppContext _context;
        private readonly IMailService _mailService;

        public VehicleAssignmentsController(RvpAppContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }

        // GET: VehicleAssignments
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehicleAssignment.ToListAsync());
        }

        // GET: VehicleAssignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleAssignment == null)
            {
                return NotFound();
            }

            return View(vehicleAssignment);
        }

        // GET: VehicleAssignments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleAssignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehReqNo,AssignNo,AssignTagNo,AssignDepartDate,AssignReturnDate,Comments")] VehicleAssignment vehicleAssignment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleAssignment);
        }

        [HttpGet]
        public IActionResult VehicleAssigned(int id) 
        {
            var vehicleRequisition = _context.VehicleRequisition.Where(c => c.VehReqNo == id).FirstOrDefault();
            return View(vehicleRequisition); 
        }

        [HttpGet]
        public async Task<IActionResult> AssignVehicle(string tagNumber, int vehReqNo)
        {
            try
            {
                var vehRequisition = await _context.VehicleRequisition.Where(c => c.VehReqNo == vehReqNo).FirstOrDefaultAsync();
                if (vehRequisition == null)
                {
                    return BadRequest();
                }
                var vehicle = await _context.Vehicle.Where(c => c.TagNumber == tagNumber).FirstOrDefaultAsync(); 
                if(vehicle == null)
                {
                    return BadRequest();
                }
                var vM = new AssignVehicleVM()
                {
                    TagNumber  = tagNumber,
                    Comments    = vehRequisition.ReqComments,
                    DepartDate = vehRequisition.ReqDepartDate,
                    ReturnDate = vehRequisition.ReqReturnDate,
                    DepartTime = vehRequisition.ReqDepartDate.ToString("HH:MM:SS"),
                    ReturnTime = vehRequisition.ReqReturnDate.ToString("HH:mm:ss"),
                    VehReqNo   = vehReqNo,
                };
                vM.VehicleWeek = Utility.GetVehicleWeek(_context, vM.DepartDate.Date.ToString("yyyyMMdd"));
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
                return View(vM);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return View("VehicleAssign");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignVehicle(AssignVehicleVM vehicleAssignment)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    VehicleRequisition vehicleRequisition = _context.VehicleRequisition.Where(c => c.VehReqNo == vehicleAssignment.VehReqNo).FirstOrDefault();
                    vehicleRequisition.ReqReturnDate = vehicleAssignment.ReturnDate;
                    vehicleRequisition.ReqDepartDate = vehicleAssignment.DepartDate;
                    vehicleRequisition.ReqComments = vehicleAssignment.Comments;
                    vehicleRequisition.VehReqStatus = "A";
                    var newAssignmentNo = _context.VehicleAssignment.Max(c => c.AssignNo) + 1;
                    _context.Update(vehicleRequisition);

                    var assignment = _context.VehicleAssignment.Where(c => c.VehReqNo.Equals(vehicleAssignment.VehReqNo)).FirstOrDefault();
                    if (assignment == null)
                    {
                        await _context.VehicleAssignment.AddAsync(new VehicleAssignment()
                        {
                            AssignNo = newAssignmentNo,
                            AssignDepartDate = vehicleAssignment.DepartDate,
                            AssignTagNo = vehicleAssignment.TagNumber,
                            AssignReturnDate = vehicleAssignment.ReturnDate,
                            Comments = vehicleAssignment.Comments,
                            VehReqNo = vehicleAssignment.VehReqNo
                        });
                    }
                    else
                    {
                        assignment.AssignReturnDate = vehicleAssignment.ReturnDate;
                        assignment.AssignDepartDate= vehicleAssignment.DepartDate;
                        assignment.Comments= vehicleAssignment.Comments;   
                        assignment.AssignTagNo= vehicleAssignment.TagNumber;
                        _context.Update(assignment);
                    }
                    await _context.SaveChangesAsync();

                    var requisitionVM = new VehicleRequisitionVM()
                    {
                        Destination = vehicleRequisition.Destination,
                        AssignedTagNo = vehicleAssignment.TagNumber,
                        Duties = vehicleRequisition.Duties,
                        EmailAddress = vehicleRequisition.EmailAddress,
                        NoInParty = vehicleRequisition.NoInParty,
                        ReqBudget = vehicleRequisition.ReqBudget,
                        ReqComments = vehicleAssignment.Comments,
                        ReqDepartDate = vehicleAssignment.DepartDate,
                        ReqReturnDate = vehicleAssignment.ReturnDate,
                        ReqSectionId = vehicleRequisition.ReqSectionId,
                        ReqDivision = vehicleRequisition.ReqDivision,
                        NotificationDivHead = vehicleRequisition.NotificationDivHead,
                        ReqFap = vehicleRequisition.ReqFap,
                        ReqFunction = vehicleRequisition.ReqFunction,
                        ReqJobNo = vehicleRequisition.ReqJobNo,
                        VehType = vehicleRequisition.VehType,
                        VehReqDate = vehicleAssignment.ReturnDate,
                        Userid = vehicleRequisition.Userid,
                        VehReqNo = vehicleAssignment.VehReqNo,
                        NotificationMan = vehicleRequisition.NotificationMan,
                        Requestor = vehicleRequisition.Requestor,
                    };
                    SendAssignmentEmails(_context, requisitionVM);
                    return View("VehicleAssigned",requisitionVM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AssignVehicle - " + ex.Message);
            }
            return View(vehicleAssignment);
        }

        private async void SendAssignmentEmails(RvpAppContext context, VehicleRequisitionVM vehicleRequisition)
        {

            var mailRequest = new MailRequest()
            {
                Attachments = null,
                Body = CreateAssignmentEmailMessage(vehicleRequisition),
                Subject = vehicleRequisition.Requestor + " has been approved by " + vehicleRequisition.Userid,
                From = "rowvehiclepool" + Utility.DefaultAddress("rowvehiclepool"),
                To = vehicleRequisition.EmailAddress
            };
            await _mailService.SendEmailAsync(mailRequest);
        }

        private string CreateAssignmentEmailMessage(VehicleRequisitionVM vehicleRequisition)
        {
            var HTML2 = "<HTML>";
            HTML2 = HTML2 + "<HEAD>";
            HTML2 = HTML2 + "<TITLE>Send Mail with HTML</TITLE>";
            HTML2 = HTML2 + "</HEAD>";
            HTML2 = HTML2 + @"<BODY  bgcolor=""lightyellow"">";
            HTML2 = HTML2 + @"<TABLE cellpadding=""4"">";
            HTML2 = HTML2 + @"<tr><td>Vehicle Tag Number: " + vehicleRequisition.AssignedTagNo + "</tr></td>";
            HTML2 = HTML2 + @"<tr><td>Vehicle Requisition Number: " + vehicleRequisition.VehReqNo + "</tr></td>";
            HTML2 = HTML2 + @"<TR><TD>";
            HTML2 = HTML2 + @"Requestor: <A HREF=""" + Url.Action("AssignVehicle", "VehicleAssignments") + @"?vehreqno=" + vehicleRequisition.VehReqNo + @""">";
            HTML2 = HTML2 + vehicleRequisition.Requestor + "</A><br>Vehicle Type: " + vehicleRequisition.VehType + "<br>Destination: " + vehicleRequisition.Destination
                            + "<br>Duties: " + vehicleRequisition.Duties + "<br>Date: " + vehicleRequisition.ReqDepartDate + " - " + vehicleRequisition.ReqReturnDate + "</tr></td>";
            HTML2 = HTML2 + "<TR><TD>Budge@t: " + vehicleRequisition.ReqBudget + "</td></tr>";
            HTML2 = HTML2 + "<TR><TD>Division: " + vehicleRequisition.ReqDivision + "</td></tr>";
            HTML2 = HTML2 + "<TR><TD>Section: " + vehicleRequisition.ReqSectionId + "</td></td>";
            HTML2 = HTML2 + "</TABLE>";
            HTML2 = HTML2 + "</BODY>";
            HTML2 = HTML2 + "</HTML>";

            return HTML2;
        }

        // GET: VehicleAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var vehicleAssignmentVM = new VehicleAssignmentVM();

            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment.Where(c=>c.VehReqNo.Equals(id)).FirstOrDefaultAsync();
            if (vehicleAssignment == null)
            {
                return NotFound();
            }
            vehicleAssignmentVM.VehicleAssignment = vehicleAssignment;
            vehicleAssignmentVM.VehicleWeek = Utility.GetVehicleWeek(_context, vehicleAssignment.AssignDepartDate.ToString("yyyyMMdd"));
            return View(vehicleAssignmentVM);
        }

        // POST: VehicleAssignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehReqNo,AssignNo,AssignTagNo,AssignDepartDate,AssignReturnDate,Comments")] VehicleAssignment vehicleAssignment)
        {
            if (id != vehicleAssignment.VehReqNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleAssignmentExists(vehicleAssignment.VehReqNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleAssignment);
        }

        // GET: VehicleAssignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleAssignment == null)
            {
                return NotFound();
            }

            return View(vehicleAssignment);
        }

        // POST: VehicleAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleAssignment = await _context.VehicleAssignment.FindAsync(id);
            _context.VehicleAssignment.Remove(vehicleAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleAssignmentExists(int id)
        {
            return _context.VehicleAssignment.Any(e => e.VehReqNo == id);
        }
    }
}
