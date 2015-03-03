using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TotMotor.Models;

namespace Totmotor.Controllers
{
    public class ContacteController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Contacte/
        public ActionResult Index()
        {
            return View(db.Contacte.ToList());
        }

        // GET: /Contacte/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contacte contacte = db.Contacte.Find(id);
            if (contacte == null)
            {
                return HttpNotFound();
            }
            return View(contacte);
        }

        // GET: /Contacte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Contacte/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Email,Telèfon,Direcció,Codi_Postal,Població,Pais")] Contacte contacte)
        {
            if (ModelState.IsValid)
            {
                db.Contacte.Add(contacte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contacte);
        }

        // GET: /Contacte/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contacte contacte = db.Contacte.Find(id);
            if (contacte == null)
            {
                return HttpNotFound();
            }
            return View(contacte);
        }

        // POST: /Contacte/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Email,Telèfon,Direcció,Codi_Postal,Població,Pais")] Contacte contacte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contacte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contacte);
        }

        // GET: /Contacte/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contacte contacte = db.Contacte.Find(id);
            if (contacte == null)
            {
                return HttpNotFound();
            }
            return View(contacte);
        }

        // POST: /Contacte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contacte contacte = db.Contacte.Find(id);
            db.Contacte.Remove(contacte);
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
