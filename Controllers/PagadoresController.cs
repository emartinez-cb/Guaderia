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
    public class PagadoresController : Controller
    {
        private GuarderiaContext db = new GuarderiaContext();

        // GET: Pagadores
        public ActionResult Index()
        {
            return View(db.Pagadores.ToList());
        }

        // GET: Pagadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagadores pagadores = db.Pagadores.Find(id);
            if (pagadores == null)
            {
                return HttpNotFound();
            }
            return View(pagadores);
        }

        // GET: Pagadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pagadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Cedula,Direccion,Telefono,CuentaCorriente")] Pagadores pagadores)
        {
            if (ModelState.IsValid)
            {
                db.Pagadores.Add(pagadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagadores);
        }

        // GET: Pagadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagadores pagadores = db.Pagadores.Find(id);
            if (pagadores == null)
            {
                return HttpNotFound();
            }
            return View(pagadores);
        }

        // POST: Pagadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Cedula,Direccion,Telefono,CuentaCorriente")] Pagadores pagadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagadores).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagadores);
        }

        // GET: Pagadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagadores pagadores = db.Pagadores.Find(id);
            if (pagadores == null)
            {
                return HttpNotFound();
            }
            return View(pagadores);
        }

        // POST: Pagadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagadores pagadores = db.Pagadores.Find(id);
            db.Pagadores.Remove(pagadores);
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
