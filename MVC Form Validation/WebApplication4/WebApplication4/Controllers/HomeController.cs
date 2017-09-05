using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Register registerModel)
        {
            if (string.IsNullOrEmpty(registerModel.UserName))
            {
                ModelState.AddModelError("UserName", "UserName is Required");
            }
            if (string.IsNullOrEmpty(registerModel.Password))
            {
                ModelState.AddModelError("Password", "Password is Required");
            }
            if (string.IsNullOrEmpty(registerModel.ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "ConfirmPassword is Required");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }

            return View(registerModel);
        }

    }
}