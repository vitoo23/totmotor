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
    public class NoticiesController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Noticies/
        public ActionResult Index()
        {
            return View(db.Noticies.ToList());
        }

        // GET: /Noticies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticies noticies = db.Noticies.Find(id);
            if (noticies == null)
            {
                return HttpNotFound();
            }
            return View(noticies);
        }

        // GET: /Noticies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Noticies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Títol,Contingut,Data_publicació,Autor_Noticia")] Noticies noticies)
        {
            if (ModelState.IsValid)
            {
                db.Noticies.Add(noticies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noticies);
        }

        // GET: /Noticies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticies noticies = db.Noticies.Find(id);
            if (noticies == null)
            {
                return HttpNotFound();
            }
            return View(noticies);
        }

        // POST: /Noticies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Títol,Contingut,Data_publicació,Autor_Noticia")] Noticies noticies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noticies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noticies);
        }

        // GET: /Noticies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticies noticies = db.Noticies.Find(id);
            if (noticies == null)
            {
                return HttpNotFound();
            }
            return View(noticies);
        }

        // POST: /Noticies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Noticies noticies = db.Noticies.Find(id);
            db.Noticies.Remove(noticies);
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
