using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
//using Microsoft.Graph.Models;
using Microsoft.Identity.Web;
using RowVehiclePoolMVC.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.Controllers
{ 
    [Authorize]

    [AuthorizeForScopes(ScopeKeySection = "MicrosoftGraph:Scopes")]
    [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
    public class HomeController : Controller
    {
        private readonly GraphServiceClient _graphServiceClient;
        IConfiguration _configuration;
        private readonly MicrosoftIdentityConsentAndConditionalAccessHandler _consentHandler;
        private readonly ILogger<HomeController> _logger;
        private string[]? _graphScopes;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration,
            GraphServiceClient graphServiceClient,
            MicrosoftIdentityConsentAndConditionalAccessHandler consentHandler)
        {
            _logger = logger;
            _graphServiceClient = graphServiceClient;
            _consentHandler = consentHandler;
            _graphScopes = configuration.GetValue<string>("DownStreamApi:Scopes").Split(' ');
        }

        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        public async Task<IActionResult> Profile()
        {
            //User? user = await _graphServiceClient.Me
            ////var user = await _graphServiceClient.Users
            //    .Request()
            //    //.Filter("mail eq 'kerrie.Johnson@ardot.gov'")
            //    //.WithAppOnly()
            //    .Select(u => new {u.DisplayName, u.JobTitle, u.Mail, u.UserPrincipalName, u.Id, u.EmployeeId, u.OfficeLocation, u.Manager, u.MobilePhone })
            //    .GetAsync();
            var user = await _graphServiceClient.Me.Request()
            //var user = await _graphServiceClient.Me.Request()
                    //.Filter("mail eq 'richard.harris@ardot.gov'")
                    //.WithAppOnly()
                    //.Select(u => new { u.DisplayName, u.Mail, u.Id, u.EmployeeId, u.MobilePhone, u.BusinessPhones, u.Manager, u.OfficeLocation })
                    .GetAsync();
            //ViewData["Me"] = user;
            ViewData["Me"] = user;// user[0];
            return View();
        }
            
        [AuthorizeForScopes(ScopeKeySection = "DownstreamApi:Scopes")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
