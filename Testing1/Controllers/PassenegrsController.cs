using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Testing1;

namespace Testing1.Controllers
{
    public class PassenegrsController : Controller
    {
        private PSEntities1 db = new PSEntities1();

        // GET: Passenegrs
        public ActionResult Index()
        {
            return View(db.Passenegrs.ToList());
        }

        // GET: Passenegrs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenegr passenegr = db.Passenegrs.Find(id);
            if (passenegr == null)
            {
                return HttpNotFound();
            }
            return View(passenegr);
        }

        // GET: Passenegrs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passenegrs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_,FirstName,LastName,Phone")] Passenegr passenegr)
        {
            if (ModelState.IsValid)
            {
                db.Passenegrs.Add(passenegr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(passenegr);
        }

        // GET: Passenegrs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenegr passenegr = db.Passenegrs.Find(id);
            if (passenegr == null)
            {
                return HttpNotFound();
            }
            return View(passenegr);
        }

        // POST: Passenegrs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_,FirstName,LastName,Phone")] Passenegr passenegr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenegr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(passenegr);
        }

        // GET: Passenegrs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenegr passenegr = db.Passenegrs.Find(id);
            if (passenegr == null)
            {
                return HttpNotFound();
            }
            return View(passenegr);
        }

        // POST: Passenegrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passenegr passenegr = db.Passenegrs.Find(id);
            db.Passenegrs.Remove(passenegr);
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
