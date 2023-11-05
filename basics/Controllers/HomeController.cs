using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(Repository.Bootcamps);
    }

    public IActionResult About()
    {
        return View();
    }

   
}
