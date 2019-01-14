using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers
{
    public class MyController : Controller
    {
        [ChildActionOnly]
        public ActionResult MyTime(){
            ViewBag.Controller = "MyController";
            return View(DateTime.Now);
        }
    }
}