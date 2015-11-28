using GymProject.Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymProject.Portal.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (Session["UserSession"] != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel lvm)
        {
            var user = lvm.GetUser();

            if (user != null)
            {
                Session["UserSession"] = user;
                return RedirectToAction("Index", "Home");
            }

            return View(lvm);
        }

        public ActionResult LogOff()
        {
            Session["UserSession"] = null;
            return RedirectToAction("Index", "Login");
        }

	}
}