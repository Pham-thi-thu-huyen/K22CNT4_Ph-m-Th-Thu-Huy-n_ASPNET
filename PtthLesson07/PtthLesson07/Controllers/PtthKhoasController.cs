using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtthLesson07.Models;

namespace PtthLesson07.Controllers
{
    public class PtthKhoasController : Controller
    {
        private PtthK22CNT4Lesson07DbEntities db = new PtthK22CNT4Lesson07DbEntities();

        // GET: PtthKhoas
        public ActionResult PtthIndex()
        {
            return View(db.PtthKhoas.ToList());
        }

        // GET: PtthKhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthKhoa ptthKhoa = db.PtthKhoas.Find(id);
            if (ptthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptthKhoa);
        }

        // GET: PtthKhoas/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: PtthKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "PtthMaKH,PtthTenKh,PtthTrangthai")] PtthKhoa ptthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.PtthKhoas.Add(ptthKhoa);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            return View(ptthKhoa);
        }

        // GET: PtthKhoas/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthKhoa ptthKhoa = db.PtthKhoas.Find(id);
            if (ptthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptthKhoa);
        }

        // POST: PtthKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "PtthMaKH,PtthTenKh,PtthTrangthai")] PtthKhoa ptthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptthKhoa);
        }

        // GET: PtthKhoas/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthKhoa ptthKhoa = db.PtthKhoas.Find(id);
            if (ptthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptthKhoa);
        }

        // POST: PtthKhoas/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtthKhoa ptthKhoa = db.PtthKhoas.Find(id);
            db.PtthKhoas.Remove(ptthKhoa);
            db.SaveChanges();
            return RedirectToAction("PtthIndex");
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
