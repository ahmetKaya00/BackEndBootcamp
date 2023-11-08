
using BootcampApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampApp.Controllers
{   
    public class HomeController : Controller
    {
         public IActionResult Index(){

            int saat = DateTime.Now.Hour;

            ViewData["Selam"] = saat > 12 ? "İyi günler":"Günaydın";
            int UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();

            var bootcampInfo = new BootcampInfo(){
                Id = 1,
                Location = "Erciyes Teknokent, Tekno 5 Salonu",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount
            };
            return View(model: bootcampInfo);
        }
    }
}