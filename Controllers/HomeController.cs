using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventFlow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["pm"] != null)
            {
                ViewBag.pm = TempData["pm"].ToString();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}