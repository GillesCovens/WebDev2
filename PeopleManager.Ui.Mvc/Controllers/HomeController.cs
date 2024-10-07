using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;
using System.Diagnostics;

namespace PeopleManager.Ui.Mvc.Controllers
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
            List<PersoonModel> personen = new List<PersoonModel>
            {
                new PersoonModel()
                {
                    Name = "John",
                    LastName = "Doe",
                    Email = "John.Doe@gmail.com"
                },
                new PersoonModel()
                {
                    Name = "Jane",
                    LastName = "Doe",
                    Email = "Jane.Doe@gmail.com"
                }
            };

            return View(personen);
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
