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
    public class EscuderiaController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Escuderia/
        public ActionResult Index()
        {
            return View(db.Escuderias.ToList());
        }

        // GET: /Escuderia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escuderia escuderia = db.Escuderias.Find(id);
            if (escuderia == null)
            {
                return HttpNotFound();
            }
            return View(escuderia);
        }

        // GET: /Escuderia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Escuderia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Nom,Logotip,Descripció,nom_pilotID")] Escuderia escuderia)
        {
            if (ModelState.IsValid)
            {
                db.Escuderias.Add(escuderia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(escuderia);
        }

        // GET: /Escuderia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escuderia escuderia = db.Escuderias.Find(id);
            if (escuderia == null)
            {
                return HttpNotFound();
            }
            return View(escuderia);
        }

        // POST: /Escuderia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Nom,Logotip,Descripció,nom_pilotID")] Escuderia escuderia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escuderia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(escuderia);
        }

        // GET: /Escuderia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escuderia escuderia = db.Escuderias.Find(id);
            if (escuderia == null)
            {
                return HttpNotFound();
            }
            return View(escuderia);
        }

        // POST: /Escuderia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Escuderia escuderia = db.Escuderias.Find(id);
            db.Escuderias.Remove(escuderia);
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
