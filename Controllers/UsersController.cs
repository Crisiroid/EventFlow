using EventFlow.Models;
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
                if(Customer.CheckLogin(username, password) == "200")
                {
                    Session["username"] = username;
                    TempData["pm"] = "Login Successful! Welcome";
                    return RedirectToAction("Panel", "Users");
                }
                else
                {
                    TempData["pm"] = "Wrong Username or Password!";
                    return RedirectToAction("Index", "Home");
                }
        }
        public ActionResult Register()
        {
            if (TempData["pm"] != null)
            {
                ViewBag.pm = TempData["pm"].ToString();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer user)
        {
            string res = Customer.Register(user);
            if(res == "200")
            {
                TempData["pm"] = "User Created Successfully. please Login!";
                return RedirectToAction("Login", "Users");
            }
            else
            {
                TempData["pm"] = res;
                return View();
            }
        }
    }
}