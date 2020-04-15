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
    public class RecogedoresController : Controller
    {
        private GuarderiaContext db = new GuarderiaContext();

        // GET: Recogedores
        public ActionResult Index()
        {
            return View(db.Recogedores.ToList());
        }

        // GET: Recogedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recogedores recogedores = db.Recogedores.Find(id);
            if (recogedores == null)
            {
                return HttpNotFound();
            }
            return View(recogedores);
        }

        // GET: Recogedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recogedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Cedula,Direccion,Telefono,Relacion")] Recogedores recogedores)
        {
            if (ModelState.IsValid)
            {
                db.Recogedores.Add(recogedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recogedores);
        }

        // GET: Recogedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recogedores recogedores = db.Recogedores.Find(id);
            if (recogedores == null)
            {
                return HttpNotFound();
            }
            return View(recogedores);
        }

        // POST: Recogedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Cedula,Direccion,Telefono,Relacion")] Recogedores recogedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recogedores).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recogedores);
        }

        // GET: Recogedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recogedores recogedores = db.Recogedores.Find(id);
            if (recogedores == null)
            {
                return HttpNotFound();
            }
            return View(recogedores);
        }

        // POST: Recogedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recogedores recogedores = db.Recogedores.Find(id);
            db.Recogedores.Remove(recogedores);
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
