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
    public class CircuitsController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Circuits/
        public ActionResult Index()
        {
            return View(db.Circuits.ToList());
        }

        // GET: /Circuits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circuits circuits = db.Circuits.Find(id);
            if (circuits == null)
            {
                return HttpNotFound();
            }
            return View(circuits);
        }

        // GET: /Circuits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Circuits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Nom_Circuit,Pais,Bandera_Pais,Quilòmetres,Any_Construcció,Num_Corbes,Descripció")] Circuits circuits)
        {
            if (ModelState.IsValid)
            {
                db.Circuits.Add(circuits);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(circuits);
        }

        // GET: /Circuits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circuits circuits = db.Circuits.Find(id);
            if (circuits == null)
            {
                return HttpNotFound();
            }
            return View(circuits);
        }

        // POST: /Circuits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Nom_Circuit,Pais,Bandera_Pais,Quilòmetres,Any_Construcció,Num_Corbes,Descripció")] Circuits circuits)
        {
            if (ModelState.IsValid)
            {
                db.Entry(circuits).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(circuits);
        }

        // GET: /Circuits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Circuits circuits = db.Circuits.Find(id);
            if (circuits == null)
            {
                return HttpNotFound();
            }
            return View(circuits);
        }

        // POST: /Circuits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Circuits circuits = db.Circuits.Find(id);
            db.Circuits.Remove(circuits);
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
