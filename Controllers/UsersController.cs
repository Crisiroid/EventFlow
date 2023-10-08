using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventFlow.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string returnUrl, string username, string password)
        {
            if(returnUrl == null)
            {

            }
        }
    }
}