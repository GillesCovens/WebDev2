using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
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
    }
}
