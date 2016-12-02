using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_To_Do_List.Models;

namespace ASP_To_Do_List.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View(Models.ListItem.GetAll());
        }

        public ActionResult Create(string TaskName, string DueDate)
        {
            Models.ListItem.Create(TaskName, DueDate);

            return RedirectToAction("Index");
        }
    }
}