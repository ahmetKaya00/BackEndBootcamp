using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers
{
    public class BootcampController : Controller
    {       
        public IActionResult Course(){
            return View("Course",Repository.Bootcamps);
        }
        public IActionResult Details(int? id){

            if(id == null){
                return Redirect("/bootcamp/course");
            }
            var kurs = Repository.GetById(id);
            return View(kurs);
        }
    }
}