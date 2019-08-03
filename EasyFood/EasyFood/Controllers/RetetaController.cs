using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasyFood.DAL;
using EasyFood.Models;
using EasyFood.ViewModels;
using EasyFood.ServiceReference2;

namespace EasyFood.Controllers
{
    public class RetetaController : Controller
    {

        private EasyFoodContext db = new EasyFoodContext();

        // GET: Reteta
        public ActionResult Index()
        {
            var retete = db.Retete.Include(d => d.Ingrediente);
            return View(retete.ToList());
        }

        // GET: Reteta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Reteta reteta = db.Retete.Find(id);
            if (reteta == null)
            {
                return HttpNotFound();
            }
           
            ValoareNutritionalaReteta vnr = new ValoareNutritionalaReteta(reteta);
            return View(vnr);
        }

        // GET: Reteta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reteta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RetetaID,Denumire,Descriere,Stoc,Pret,LinkImaginePrezentare,NivelDificultate,TimpPreparare,Categorie,LinkVideo")] Reteta reteta)
        {
            if (ModelState.IsValid)
            {
                db.Retete.Add(reteta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reteta);
        }

        // GET: Reteta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reteta reteta = db.Retete.Find(id);
            if (reteta == null)
            {
                return HttpNotFound();
            }
            return View(reteta);
        }

        // POST: Reteta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RetetaID,Denumire,Descriere,Stoc,Pret,LinkImaginePrezentare,NivelDificultate,TimpPreparare,Categorie,LinkVideo")] Reteta reteta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reteta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reteta);
        }

        // GET: Reteta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reteta reteta = db.Retete.Find(id);
            if (reteta == null)
            {
                return HttpNotFound();
            }
            return View(reteta);
        }

        // POST: Reteta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reteta reteta = db.Retete.Find(id);
            db.Retete.Remove(reteta);
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
