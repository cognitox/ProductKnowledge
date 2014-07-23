using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowSL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String message = @"")
        {
            ViewBag.Message = message;
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
