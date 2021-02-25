using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.SerVice;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReportSerVice _reportSerVice;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IReportSerVice reportSerVice)
        {
            _reportSerVice = reportSerVice;
            _logger = logger;
        }

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
        public async Task<IActionResult> GetRevenue(string fromDate, string toDate)
        {
            return new OkObjectResult(await _reportSerVice.GetReportAsync(fromDate, toDate));
        }
    }
}
