using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class BootcampController : Controller{

    public IActionResult Index(){
        return View();
    }
    public IActionResult List(){
        return View();
    }

}