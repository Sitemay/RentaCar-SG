using RentAcar_SG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RentAcar_SG.Controllers
{
    public class MyAdminController : Controller
    {
        private VehicleContext context = new VehicleContext();
        // GET: MyAdmin
        public ActionResult MyAdmin()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MyAdmin(MyAdmin admin)
        {
            var obj = context.MyAdmins.Where(i => i.name.Equals(admin.name) && i.passwd.Equals(admin.passwd)).FirstOrDefault();
            if (obj != null)
            {
                Session["name"] = obj;
                return RedirectToAction("Index", "Vehicle");
            }
            else
                ModelState.AddModelError("name","Kullanıcı Adı veya Şifre Yanlış");
                return View(admin);
        }
        
    }
    
}