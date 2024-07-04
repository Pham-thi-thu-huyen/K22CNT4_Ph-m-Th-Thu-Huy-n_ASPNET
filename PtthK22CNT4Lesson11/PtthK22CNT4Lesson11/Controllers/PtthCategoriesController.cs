using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtthK22CNT4Lesson11.Models;

namespace PtthK22CNT4Lesson11.Controllers
{
    public class PtthCategoriesController : Controller
    {
        private PtthK22CNT4Lesson11DbEntities db = new PtthK22CNT4Lesson11DbEntities();

        // GET: PtthCategories
        public ActionResult Index()
        {
            return View(db.PtthCategories.ToList());
        }

        // GET: PtthCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthCategory ptthCategory = db.PtthCategories.Find(id);
            if (ptthCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptthCategory);
        }

        // GET: PtthCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtthCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtthID,PtthCateName,PtthStatus")] PtthCategory ptthCategory)
        {
            if (ModelState.IsValid)
            {
                db.PtthCategories.Add(ptthCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptthCategory);
        }

        // GET: PtthCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthCategory ptthCategory = db.PtthCategories.Find(id);
            if (ptthCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptthCategory);
        }

        // POST: PtthCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtthID,PtthCateName,PtthStatus")] PtthCategory ptthCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptthCategory);
        }

        // GET: PtthCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthCategory ptthCategory = db.PtthCategories.Find(id);
            if (ptthCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptthCategory);
        }

        // POST: PtthCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtthCategory ptthCategory = db.PtthCategories.Find(id);
            db.PtthCategories.Remove(ptthCategory);
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
