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
using System.Reflection;

namespace EasyFood.Controllers
{
    public class ClientController : Controller
    {
        private EasyFoodContext db = new EasyFoodContext();

        // GET: Client
        public ActionResult Index()
        {
            return View(db.Clienti.ToList());
        }

        public ActionResult Autentificare(string username, string parola)
        {
            Client client;

            if (TempData["IDUtilizator"] == null)
            {
                
                if (username == null || parola == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                IQueryable<EasyFood.Models.Client> clienti =
                                    from cl in db.Clienti
                                    where cl.Email == username && cl.Parola == parola
                                    select cl;

                if (clienti.Count() == 1)
                {
                    client = clienti.Single();
                    TempData["IDUtilizator"] = client.ID;
                    return View(client);
                }
                else
                {
                    return HttpNotFound();
                }
                
            }

            TempData.Keep();

            client = db.Clienti.Find(TempData["IDUtilizator"]);
            TempData.Keep();

            if (client == null)
            {
                return HttpNotFound();
            }
             
            return View(client);
            
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nume,Prenume,Email,DataNasterii,Adresa,Parola,LinkPoza")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clienti.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clienti.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nume,Prenume,Email,DataNasterii,Adresa,Parola,LinkPoza")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { ID = client.ID});
            }
            return View(client);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clienti.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Clienti.Find(id);
            db.Clienti.Remove(client);
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
