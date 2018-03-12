using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaOnlineMVC.MVC.Models;
using TiendaOnlineMVC.MVC.Utils;

namespace TiendaOnlineMVC.MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            Connect connect = new Connect(model.UserName, model.Password);

            return RedirectToAction("Index", "Home");

        }

        public ActionResult LogOff()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Login");
        }
    }
}