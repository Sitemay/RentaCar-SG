using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentAcar_SG.Models;

namespace RentAcar_SG.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: Vehicle
        public ActionResult Index()
        {
            var vehicles = db.Vehicles.Include(v => v.Category);
            return View(vehicles.ToList());
        }
        public ActionResult List(int? id, string q)
        {
            var vehicles = db.Vehicles
               .Select(i => new VehicleModel()
               {
                   Id = i.Id,
                   AracAdi = i.AracAdi,
                   ModelAdi = i.ModelAdi,
                   ModelYili = i.ModelYili,
                   Resim = i.Resim,
                   Uyggunluk = i.Uyggunluk,
                   Anasayfa = i.Anasayfa,
                   CategoryId = i.CategoryId

               }).AsQueryable();

            if (id != null)
            {
                vehicles = vehicles.Where(i => i.CategoryId == id);

            }

            if (string.IsNullOrEmpty("q") == false)
            {
                vehicles = vehicles.Where(i => i.AracAdi.Contains(q) || i.ModelAdi.Contains(q));

            }

            return View(vehicles.ToList());
        }
        // GET: Vehicle/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "KategoriAdi");
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AracAdi,ModelAdi,ModelYili,Resim,Fiyat,Uyggunluk,Anasayfa,CategoryId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "KategoriAdi", vehicle.CategoryId);
            return View(vehicle);
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "KategoriAdi", vehicle.CategoryId);
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AracAdi,ModelAdi,ModelYili,Resim,Fiyat,Uyggunluk,Anasayfa,CategoryId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "KategoriAdi", vehicle.CategoryId);
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
