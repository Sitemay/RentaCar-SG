using RentAcar_SG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentAcar_SG.Controllers
{
    public class LoginController : Controller
    {
        private VehicleContext context = new VehicleContext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            var obj = context.Logins.Where(i => i.username.Equals(login.username) && i.password.Equals(login.password)).FirstOrDefault();
            if (obj != null)
            {
                Session["username"] = obj;
                return RedirectToAction("Index", "Home");
            }
            else
                ModelState.AddModelError("username", "Kullanıcı Adı veya Şifre Yanlış");
            return View(login);
        }

        public ActionResult Kayit()
        {
            return View();
        }

        // POST: Kayit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kayit([Bind(Include = "Id,username,password")] Login login)
        {
            if (ModelState.IsValid)
            {
                context.Logins.Add(login);
                context.SaveChanges();
                return RedirectToAction("Login","Login");
            }

           
            return View(login);
        }



    }
}