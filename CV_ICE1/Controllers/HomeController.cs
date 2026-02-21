using System.Diagnostics;
using CV_ICE1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_ICE1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult DownloadCV()
        {
                string file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","Documents", "Enhle_Mokholo_CV.pdf");

                if (!System.IO.File.Exists(file))
                {
                    return NotFound();
                }


                var stream= new FileStream(file, FileMode.Open, FileAccess.Read);
                return File(stream, "application/pdf", "Enhle_Mokholo_CV.pdf");
        }

      
    }
}
