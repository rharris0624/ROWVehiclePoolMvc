using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RowVehiclePoolMVC.Context;
using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.Controllers
{
    //[Route("[Controller]")]
    public class VehicleController : Controller
    {
        public RvpAppContext _context { get; set; }
        public RvpAppEqpContext _eqpContext { get; set; }

        public VehicleController(RvpAppContext context, RvpAppEqpContext eqpContext)
        {
            _context = context;
            _eqpContext = eqpContext;
        }
        public IActionResult Index()
        {
            var vehicles = _context.Vehicle.Where(c => c.Status != "i").ToList();
            return View(vehicles);
        }
        [HttpGet]
        public IActionResult AssignmentDetail(decimal assignNo)
        {
            var assignDetail = _context.VehicleAssignment.Where(a => a.AssignNo == assignNo).Join(_context.VehicleRequisition, va => va.VehReqNo, vr => vr.VehReqNo,
                (va, vr) => new {
                    va.VehReqNo,
                    vr.Requestor,
                    vr.ReqDepartDate,
                    vr.ReqReturnDate,
                    vr.Destination,
                    vr.Duties,
                    vr.NoInParty,
                    vr.ReqBudget,
                    vr.ReqJobNo,
                    vr.ReqFunction,
                    vr.ReqFap,
                    va.Comments,
                    vr.Userid,
                    va.AssignTagNo
                })
                .Select(e => new RequestDetailVM
                {
                    VehicleRequestNumber = e.VehReqNo,
                    Requestor = e.Requestor,
                    DepartDate = e.ReqDepartDate,
                    ReturnDate = e.ReqReturnDate,
                    Destination = e.Destination,
                    Duties = e.Duties,
                    NoInParty = e.NoInParty,
                    Budget = e.ReqBudget,
                    JobNo = e.ReqJobNo,
                    Function = e.ReqFunction,
                    Fap = e.ReqFap,
                    Comments = e.Comments,
                    UserId = e.Userid,
                    TagNumber = e.AssignTagNo
                }).FirstOrDefault();
            return View(assignDetail);
        }

        [HttpGet]
        public IActionResult AddVehicle(string searchString)
        {
            AddVehicleVM addVehicleVM = new AddVehicleVM()
            {
                Color = "",
                VehicleType = "",
            };
            return View(addVehicleVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddVehicle(AddVehicleVM addVehicleVM)
        {
            if (ModelState.IsValid)
            {
                var vehicle = _context.Vehicle.Where(c=>c.TagNumber== addVehicleVM.TagNumber).FirstOrDefault();

                var vehicleAssignments = _context.VehicleAssignment.Where(c => c.AssignTagNo == addVehicleVM.TagNumber).ToList();
                foreach(var assignment in vehicleAssignments)
                {
                    var requests = _context.VehicleRequisition.Where(c => c.VehReqNo == assignment.VehReqNo).ToList();
                    foreach(var request in requests)
                    {
                        _context.VehicleRequisition.Remove(request);
                    }
                    _context.VehicleAssignment.Remove(assignment);
                }
                _context.Vehicle.Remove(vehicle);

                vehicle = new Vehicle()
                {
                    Make = addVehicleVM.Make,
                    Color = addVehicleVM.Color,
                    Model= addVehicleVM.Model,
                    OutOfServiceBegin = new DateTime(addVehicleVM.ServiceYear,addVehicleVM.ServiceMonth,addVehicleVM.ServiceDay),
                    Status = "i",
                    VehicleType= addVehicleVM.VehicleType,
                    TagNumber= addVehicleVM.TagNumber,
                    OwnerBudget=addVehicleVM.OwnerBudget,
                    VehYear=addVehicleVM.VehYear,
                    Mileage=0,
                };
                _context.Vehicle.Add(vehicle);
                _context.SaveChanges();
            }

            return View(addVehicleVM);
        }

        [HttpGet]
        public IActionResult Weekly(String sDate)
        {
            DateTime dDate;
            if (!DateTime.TryParse(sDate, out dDate))
            {
                dDate = DateTime.Now;
            }
            var dayOfWeek = dDate.DayOfWeek;
            var firstDayOfWeek = dDate.AddDays(-(int)dayOfWeek + 1);
            var lastDayOfWeek = firstDayOfWeek.AddDays(6);
            IList<WeeklyVehicleUsage> weeklyVehicleUsages = new List<WeeklyVehicleUsage>();

            //Create a list of vehicles ordered by type and tag number
            //Create a list of assignments in the range of the first and last days of the week
            //populate the view model with the vehicles and assignments
            var vehicles = _context.Vehicle.Where(c => !c.Status.Equals("i")).OrderBy(c => c.VehicleType).ThenBy(c => c.TagNumber).ToList();
            IList<UsageInstance> usageInstances = null;
            try
            {
                usageInstances = _context.VehicleAssignment.Join(_context.VehicleRequisition, vAssign => vAssign.VehReqNo, vRequest => vRequest.VehReqNo, (vAssign, vRequest) => new { vAssign, vRequest })
                .Where(c => c.vAssign.AssignDepartDate.Date >= firstDayOfWeek.Date && c.vAssign.AssignDepartDate.Date <= lastDayOfWeek.Date)
                .Select(c => new UsageInstance
                {
                    Requestor = c.vRequest.Requestor,
                    TagNumber = c.vAssign.AssignTagNo,
                    AssignNo = c.vAssign.AssignNo,
                    UsageDepartDate = c.vAssign.AssignDepartDate,
                    UsageReturnDate = c.vAssign.AssignReturnDate,
                }).OrderBy(c => c.TagNumber).ThenBy(c => c.AssignNo).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
                throw;
            }
            var vehicleWeekVM = new VehicleWeekVM(vehicles, usageInstances, dDate);
            return View(vehicleWeekVM);
        }

        [HttpGet]
        public IActionResult ShowAllVehicles()
        {
                var vehicles = _context.Vehicle.Select(c => c).OrderBy(c=>c.TagNumber).ToList();
                return PartialView("_ShowAllVehicles", vehicles);
        }
        [HttpPost]
        public IActionResult GetVehicleInfo(AddVehicleVM addVehicleVM)
        {
            IList<SelectListItem> budgetList = new List<SelectListItem>();
            using (RvpAppBudContext rvpAppBudContext = new RvpAppBudContext())
            {
                budgetList = rvpAppBudContext.T101BudgetInf.Where(c => c.PahrBudget.Equals("Y") && c.PayrEndDate == null).Select(c => new SelectListItem { Text = c.Budget, Value = c.Budget }).ToList();
            };
            ViewBag.Budgets = budgetList.Prepend(new SelectListItem() { Text = "Select", Value = "" });

            var vehicleTypes = new List<SelectListItem>() {
                                                                new SelectListItem{Text="Car",Value="Car" },
                                                                new SelectListItem{Text="Pickup",Value="Pickup" }
                                                              };
            
            ViewBag.VehicleTypes = vehicleTypes.Prepend(new SelectListItem() { Text = "Select", Value = "" });

            var vehicle = _eqpContext.OrainfEquipmentTemp.Where(c=>c.SerialCode.Equals(addVehicleVM.TagNumber)).FirstOrDefault();
            if (vehicle != null)
            {
                int serviceYear = 0;
                addVehicleVM = new AddVehicleVM()
                {
                    TagNumber = vehicle.SerialCode,
                    Make = vehicle.Vehmake,
                    Color = "",
                    Model = vehicle.Vehmodel,
                    OwnerBudget = string.IsNullOrEmpty(vehicle.Budget) ? "" : vehicle.Budget ,
                    VehicleType = "",
                    ServiceYear = int.TryParse(vehicle.Vehyear,out serviceYear) ? serviceYear : 0,
                    VehYear = int.TryParse(vehicle.Vehyear,out serviceYear) ? serviceYear : 0,
                    searchSuccessful = true,
                };
            }
            else
                addVehicleVM.searchSuccessful = false;

            return View("AddVehicle", addVehicleVM);
        }
        
        [HttpGet]
        public IActionResult Edit(string tagNumber)
        {
            if (!string.IsNullOrEmpty(tagNumber))
            {
                var vehicle = _context.Vehicle.Where(c=>c.TagNumber.Equals(tagNumber)).FirstOrDefault();
                if (vehicle != null)
                {
                    return View("Edit",vehicle);
                }
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult Edit(Vehicle vehicle)
        {
            if(ModelState.IsValid)
            {
                _context.Vehicle.Update(vehicle);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("index");
        }
    }
}
