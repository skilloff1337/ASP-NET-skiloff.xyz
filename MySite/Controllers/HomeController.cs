using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using MySite.Models;

namespace MySite.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
         //   ViewData["Year"] = DateTime.Now.Year;
        }

        [Route("/")]
        public IActionResult Index()
        {
          //  ViewData["Year"] = DateTime.Now.Year;
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
          //  ViewData["Year"] = DateTime.Now.Year;
            return View();
        }
        [Route("Test")]
        public IActionResult Test()
        {
            return View();
        }       
        [Route("404")]
        public IActionResult NotFound()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}