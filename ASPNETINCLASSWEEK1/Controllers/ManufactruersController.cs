using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNETINCLASSWEEK1.Models;

namespace ASPNETINCLASSWEEK1.Controllers
{
    public class ManufactruersController : Controller
    {
        private ASPNETINCLASSWEEK1Context db = new ASPNETINCLASSWEEK1Context();

        // GET: Manufactruers
        public ActionResult Index()
        {
            return View(db.Manufactruers.ToList());
        }

        // GET: Manufactruers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactruer manufactruer = db.Manufactruers.Find(id);
            if (manufactruer == null)
            {
                return HttpNotFound();
            }
            return View(manufactruer);
        }

        // GET: Manufactruers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufactruers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Manufactruer_ID,Make")] Manufactruer manufactruer)
        {
            if (ModelState.IsValid)
            {
                db.Manufactruers.Add(manufactruer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufactruer);
        }

        // GET: Manufactruers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactruer manufactruer = db.Manufactruers.Find(id);
            if (manufactruer == null)
            {
                return HttpNotFound();
            }
            return View(manufactruer);
        }

        // POST: Manufactruers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manufactruer_ID,Make")] Manufactruer manufactruer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufactruer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufactruer);
        }

        // GET: Manufactruers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufactruer manufactruer = db.Manufactruers.Find(id);
            if (manufactruer == null)
            {
                return HttpNotFound();
            }
            return View(manufactruer);
        }

        // POST: Manufactruers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufactruer manufactruer = db.Manufactruers.Find(id);
            db.Manufactruers.Remove(manufactruer);
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
