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
    public class WikiController : Controller
    {
        private TotMotorContext db = new TotMotorContext();

        // GET: /Wiki/
        public ActionResult Index()
        {
            return View(db.Wiki.ToList());
        }

        // GET: /Wiki/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wiki wiki = db.Wiki.Find(id);
            if (wiki == null)
            {
                return HttpNotFound();
            }
            return View(wiki);
        }

        // GET: /Wiki/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Wiki/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Contingut,Autor_Contingut,DataPublicacio")] Wiki wiki)
        {
            if (ModelState.IsValid)
            {
                db.Wiki.Add(wiki);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wiki);
        }

        // GET: /Wiki/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wiki wiki = db.Wiki.Find(id);
            if (wiki == null)
            {
                return HttpNotFound();
            }
            return View(wiki);
        }

        // POST: /Wiki/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Contingut,Autor_Contingut,DataPublicacio")] Wiki wiki)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wiki).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wiki);
        }

        // GET: /Wiki/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wiki wiki = db.Wiki.Find(id);
            if (wiki == null)
            {
                return HttpNotFound();
            }
            return View(wiki);
        }

        // POST: /Wiki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Wiki wiki = db.Wiki.Find(id);
            db.Wiki.Remove(wiki);
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
