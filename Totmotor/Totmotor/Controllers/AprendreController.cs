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
    public class AprendreController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Aprendre/
        public ActionResult Index()
        {
            return View(db.Aprendre.ToList());
        }

        // GET: /Aprendre/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aprendre aprendre = db.Aprendre.Find(id);
            if (aprendre == null)
            {
                return HttpNotFound();
            }
            return View(aprendre);
        }

        // GET: /Aprendre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Aprendre/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,titol,Contingut,AutorContingut,Tag")] Aprendre aprendre)
        {
            if (ModelState.IsValid)
            {
                db.Aprendre.Add(aprendre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aprendre);
        }

        // GET: /Aprendre/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aprendre aprendre = db.Aprendre.Find(id);
            if (aprendre == null)
            {
                return HttpNotFound();
            }
            return View(aprendre);
        }

        // POST: /Aprendre/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,titol,Contingut,AutorContingut,Tag")] Aprendre aprendre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aprendre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aprendre);
        }

        // GET: /Aprendre/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aprendre aprendre = db.Aprendre.Find(id);
            if (aprendre == null)
            {
                return HttpNotFound();
            }
            return View(aprendre);
        }

        // POST: /Aprendre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Aprendre aprendre = db.Aprendre.Find(id);
            db.Aprendre.Remove(aprendre);
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
