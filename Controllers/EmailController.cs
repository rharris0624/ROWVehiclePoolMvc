using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmailController : Controller
    {
        [Route("[Action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
