using RentAcar_SG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RentAcar_SG.Controllers
{
    public class HomeController : Controller
    {
        private VehicleContext context = new VehicleContext();
        // GET: Home
        public ActionResult Index()
        {
            var vehicles = context.Vehicles
                .Select(i => new VehicleModel()
                {
                    Id = i.Id,
                    AracAdi = i.AracAdi,
                    ModelAdi = i.ModelAdi,
                    ModelYili = i.ModelYili,
                    Resim = i.Resim,
                    Uyggunluk = i.Uyggunluk,
                    Anasayfa = i.Anasayfa

                });
               
            return View(vehicles.ToList());
        }

        
 

    }
}