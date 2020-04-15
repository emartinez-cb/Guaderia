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
    public class ComidaPnsController : Controller
    {
        private GuarderiaContext db = new GuarderiaContext();

        // GET: ComidaPns
        public ActionResult Index()
        {
            return View(db.ComidaPn.ToList());
        }

        // GET: ComidaPns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComidaPn comidaPn = db.ComidaPn.Find(id);
            if (comidaPn == null)
            {
                return HttpNotFound();
            }
            return View(comidaPn);
        }

        // GET: ComidaPns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComidaPns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Matricula,NinoNombre,FechaComida")] ComidaPn comidaPn)
        {
            if (ModelState.IsValid)
            {
                db.ComidaPn.Add(comidaPn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comidaPn);
        }

        // GET: ComidaPns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComidaPn comidaPn = db.ComidaPn.Find(id);
            if (comidaPn == null)
            {
                return HttpNotFound();
            }
            return View(comidaPn);
        }

        // POST: ComidaPns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Matricula,NinoNombre,FechaComida")] ComidaPn comidaPn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comidaPn).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comidaPn);
        }

        // GET: ComidaPns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComidaPn comidaPn = db.ComidaPn.Find(id);
            if (comidaPn == null)
            {
                return HttpNotFound();
            }
            return View(comidaPn);
        }

        // POST: ComidaPns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComidaPn comidaPn = db.ComidaPn.Find(id);
            db.ComidaPn.Remove(comidaPn);
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
