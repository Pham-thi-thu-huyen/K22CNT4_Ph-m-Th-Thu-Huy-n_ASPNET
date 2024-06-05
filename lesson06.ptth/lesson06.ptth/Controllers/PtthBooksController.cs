using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lesson06.ptth.Models;

namespace lesson06.ptth.Controllers
{
    public class PtthBooksController : Controller
    {
        private PtthBookStore db = new PtthBookStore();

        // GET: PtthBooks
        public ActionResult Index()
        {
            return View(db.PtthBooks.ToList());
        }

        // GET: PtthBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthBook ptthBook = db.PtthBooks.Find(id);
            if (ptthBook == null)
            {
                return HttpNotFound();
            }
            return View(ptthBook);
        }

        // GET: PtthBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtthBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtthId,PtthBookId,PtthTitle,PtthAuthor,PtthYear,PtthPulisher,PtthPicture,PtthCategoryId")] PtthBook ptthBook)
        {
            if (ModelState.IsValid)
            {
                db.PtthBooks.Add(ptthBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptthBook);
        }

        // GET: PtthBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthBook ptthBook = db.PtthBooks.Find(id);
            if (ptthBook == null)
            {
                return HttpNotFound();
            }
            return View(ptthBook);
        }

        // POST: PtthBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtthId,PtthBookId,PtthTitle,PtthAuthor,PtthYear,PtthPulisher,PtthPicture,PtthCategoryId")] PtthBook ptthBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptthBook);
        }

        // GET: PtthBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthBook ptthBook = db.PtthBooks.Find(id);
            if (ptthBook == null)
            {
                return HttpNotFound();
            }
            return View(ptthBook);
        }

        // POST: PtthBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtthBook ptthBook = db.PtthBooks.Find(id);
            db.PtthBooks.Remove(ptthBook);
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
