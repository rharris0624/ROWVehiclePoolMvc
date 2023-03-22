using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RowVehiclePoolMVC.Context;
using RowVehiclePoolMVC.ViewModels;
using System.Text.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RowVehiclePoolMVC.Models;

namespace RowVehiclePoolMVC.Controllers
{
    public class AllotmentController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RvpAppAlltContext _context;
        public AllotmentController(RvpAppAlltContext context)
        {
            _context = context;
        }
        [HttpGet]
        public JsonResult SearchAllotmentsByJob(string jobNo)
        {
            IQueryable<AllotDetail> result = null;
            if (string.IsNullOrEmpty(jobNo))
                result = _context.AllotDetail.Where(c=>(c.Func.Trim() == "3000" || c.Func.Trim() == "3001" || c.Func.Trim() == "3150" || c.Func.Trim() == "3151") &&
                                            (c.FuncType == "1" || c.FuncType == "2"));
            else
                result = _context.AllotDetail.Where(c => (c.JobNum.Trim().Substring(0,jobNo.Length) == jobNo) && 
                                            (c.Func.Trim() == "3000" || c.Func.Trim() == "3001" || c.Func.Trim() == "3150" || c.Func.Trim() == "3151") && 
                                            (c.FuncType == "1" || c.FuncType == "2"));
            if (result != null)
                return Json(result.Select(c => new FunctionSearch { Job = c.JobNum, Function = c.Func, FAP = c.FapNum }).ToList());
            else
                return null;
        }
        public ActionResult SelectJobFunction()
        {

            var jobList = _context.AllotDetail.Distinct().Select(c => new FunctionSearch { Job = c.JobNum, Function = c.Func, FAP = c.FapNum }).ToList();
            return PartialView("_SelectJobFunction",Json(jobList));

        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult PostJobFunction(FunctionSearch functionSearch)
        {
            if (!ModelState.IsValid)
                return PartialView("_SelectJobFunction");


            return RedirectToAction("RequestPoolVehicle", "VehicleRequisitions", null);// functionSearch);
        }
    }
}
