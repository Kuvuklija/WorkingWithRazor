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
        public ActionResult Time(DateTime time){
            return View(time);
        }
    }
}