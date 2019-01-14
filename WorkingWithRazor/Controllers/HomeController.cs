using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(){
            string[] names = { "Apple", "Orange", "Pear" };
            return View(names);
        }

        public ActionResult List() {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Time() {
            ViewBag.Controller = "Home";
            return PartialView(DateTime.Now);
        }
    }
}