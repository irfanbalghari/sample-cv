using CVSampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Models.SoftwareEngineer;
using System.Diagnostics;

namespace CVSampleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cv()
        {
            var softwareEngineer = new SoftwareEngineer
            {
                Name = "John Balghari",
                Email = "john@balghari.com",
                Phone = "123-456-7890",
                Skills = new[] { "C#", ".NET", "ASP.NET", "SQL Server", "JavaScript" },
                WorkExperience = new WorkExperience
                {
                    Company = "Balghari Solutions Inc.",
                    Position = "Senior Software Engineer",
                    Duration = "2018 - Present",
                    Responsibilities = "Developing and maintaining web applications using ASP.NET and C#."
                }
            };

            return View(softwareEngineer);
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
