using ASP_DataTransfer_DbContext.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_DataTransfer_DbContext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Fuad";
            ViewData["Surname"] = "Topchiyev";
            TempData["Age"] = "20";

            
            
            List<Student> students = new List<Student>
            {
                new Student {Id=1,Name="Ali",Surname="Talibov"},
                new Student {Id=2,Name="Omer",Surname="Imanov"},
                new Student {Id=3,Name="Aqil",Surname="Xelilov"},
            };

            List<Group> groups = new List<Group>
            {
                new Group {Id=1,Name="P321"},
                new Group {Id=2,Name="P322"},
                new Group {Id=3,Name="P323"}
            };

            ViewBag.Students = students;

            HomeVM home = new HomeVM();
            home.Groups = groups;
            home.Students=students;

            //return RedirectToAction();
            //return RedirectToAction(nameof(About));
            return View(students);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
