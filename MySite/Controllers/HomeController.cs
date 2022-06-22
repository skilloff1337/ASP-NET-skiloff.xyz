using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using MySite.Models;
using MySite.Models.CsStatistics;
using MySite.Models.CsStatistics.MapsStats;
using MySite.Models.CsStatistics.ProfileStats;
using MySite.Models.CsStatistics.WeaponsStats;
using MySite.Models.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MySite.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRequestCsGo _requestCs;

        public HomeController(ILogger<HomeController> logger, IRequestCsGo requestCs)
        {
            _logger = logger;
            _requestCs = requestCs;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Social")]
        public IActionResult Social()
        {
            return View();
        }
        [Route("Test")]
        public IActionResult Test()
        {
            return Content($"{_requestCs.NextRequest} {DateTime.Now}");
        }
        [Route("Statistics")]
        public IActionResult Statistics()
        {
            var data = _requestCs.GetData();
            if (data == null)
                return Content($"Error to load statistics. Try again at {_requestCs.NextRequest}");
            return View(data);
        }

        [Route("404")]
        public IActionResult NotFound()
        {
            return View("NotFound");
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}