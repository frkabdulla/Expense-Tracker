using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proj.Models;

namespace proj.Controllers
{
    public class SourceOfIncomesController : Controller
    {
        private ExpnsEntities db = new ExpnsEntities();

        // GET: SourceOfIncomes
        public ActionResult Index()
        {
            return View(db.SourceOfIncomes.ToList());
        }

        // GET: SourceOfIncomes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SourceOfIncome sourceOfIncome = db.SourceOfIncomes.Find(id);
            if (sourceOfIncome == null)
            {
                return HttpNotFound();
            }
            return View(sourceOfIncome);
        }

        // GET: SourceOfIncomes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SourceOfIncomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Source_Name,Source_Price,Date")] SourceOfIncome sourceOfIncome)
        {
            if (ModelState.IsValid)
            {
                db.SourceOfIncomes.Add(sourceOfIncome);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sourceOfIncome);
        }

        // GET: SourceOfIncomes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SourceOfIncome sourceOfIncome = db.SourceOfIncomes.Find(id);
            if (sourceOfIncome == null)
            {
                return HttpNotFound();
            }
            return View(sourceOfIncome);
        }

        // POST: SourceOfIncomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Source_Name,Source_Price,Date")] SourceOfIncome sourceOfIncome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sourceOfIncome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sourceOfIncome);
        }

        // GET: SourceOfIncomes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SourceOfIncome sourceOfIncome = db.SourceOfIncomes.Find(id);
            if (sourceOfIncome == null)
            {
                return HttpNotFound();
            }
            return View(sourceOfIncome);
        }

        // POST: SourceOfIncomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SourceOfIncome sourceOfIncome = db.SourceOfIncomes.Find(id);
            db.SourceOfIncomes.Remove(sourceOfIncome);
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
