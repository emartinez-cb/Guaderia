using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Guarderia.Models;

namespace Guarderia.Controllers
{
    public class NinosController : Controller
    {
        private GuarderiaContext db = new GuarderiaContext();

        // GET: Ninos
        public ActionResult Index()
        {
            return View(db.Ninos.ToList());
        }

        // GET: Ninos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninos ninos = db.Ninos.Find(id);
            if (ninos == null)
            {
                return HttpNotFound();
            }
            return View(ninos);
        }

        // GET: Ninos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ninos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Alergias,FechaDeBaja,Matricula,FechaDeNacimiento,Recogedor")] Ninos ninos)
        {
            if (ModelState.IsValid)
            {
                db.Ninos.Add(ninos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ninos);
        }

        // GET: Ninos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninos ninos = db.Ninos.Find(id);
            if (ninos == null)
            {
                return HttpNotFound();
            }
            return View(ninos);
        }

        // POST: Ninos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Alergias,FechaDeBaja,Matricula,FechaDeNacimiento")] Ninos ninos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ninos).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ninos);
        }

        // GET: Ninos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninos ninos = db.Ninos.Find(id);
            if (ninos == null)
            {
                return HttpNotFound();
            }
            return View(ninos);
        }

        // POST: Ninos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ninos ninos = db.Ninos.Find(id);
            db.Ninos.Remove(ninos);
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
