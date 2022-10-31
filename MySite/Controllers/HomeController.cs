using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySite.Models;
using MySite.Services;

namespace MySite.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICsGoDataProvider _cs;

        public HomeController(ILogger<HomeController> logger, ICsGoDataProvider cs)
        {
            _logger = logger;
            _cs = cs;
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
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [Route("Statistics")]
        public async Task<IActionResult> Statistics()
        {
            var data = await _cs.GetData();
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