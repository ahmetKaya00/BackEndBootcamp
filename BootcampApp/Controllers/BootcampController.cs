using BootcampApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampApp.Controllers
{
   
    public class BootcampController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model){

            if(ModelState.IsValid){
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();
            return View("Thanks",model);
            }else{
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult List(){
            return View(Repository.Users);
        }

        public IActionResult Details(int id){
            return View(Repository.GetByID(id));
        }
    }
}