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
    public class PtthSinhViensController : Controller
    {
        private PtthK22CNT4Lesson07DbEntities db = new PtthK22CNT4Lesson07DbEntities();

        // GET: PtthSinhViens
        public ActionResult PtthIndex()
        {
            var ptthSinhViens = db.PtthSinhViens.Include(p => p.PtthKhoa);
            return View(ptthSinhViens.ToList());
        }

        // GET: PtthSinhViens/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthSinhVien ptthSinhVien = db.PtthSinhViens.Find(id);
            if (ptthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptthSinhVien);
        }

        // GET: PtthSinhViens/Create
        public ActionResult PtthCreate()
        {
            ViewBag.PtthMaKH = new SelectList(db.PtthKhoas, "PtthMaKH", "PtthTenKh");
            return View();
        }

        // POST: PtthSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "PtthMaSV,PtthHoSV,PtthTenSV,PtthPhai,PtthEmail,PtthPhone,PtthMaKH,PtthTrangthai")] PtthSinhVien ptthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.PtthSinhViens.Add(ptthSinhVien);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            ViewBag.PtthMaKH = new SelectList(db.PtthKhoas, "PtthMaKH", "PtthTenKh", ptthSinhVien.PtthMaKH);
            return View(ptthSinhVien);
        }

        // GET: PtthSinhViens/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthSinhVien ptthSinhVien = db.PtthSinhViens.Find(id);
            if (ptthSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtthMaKH = new SelectList(db.PtthKhoas, "PtthMaKH", "PtthTenKh", ptthSinhVien.PtthMaKH);
            return View(ptthSinhVien);
        }

        // POST: PtthSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "PtthMaSV,PtthHoSV,PtthTenSV,PtthPhai,PtthEmail,PtthPhone,PtthMaKH,PtthTrangthai")] PtthSinhVien ptthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            ViewBag.PtthMaKH = new SelectList(db.PtthKhoas, "PtthMaKH", "PtthTenKh", ptthSinhVien.PtthMaKH);
            return View(ptthSinhVien);
        }

        // GET: PtthSinhViens/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthSinhVien ptthSinhVien = db.PtthSinhViens.Find(id);
            if (ptthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptthSinhVien);
        }

        // POST: PtthSinhViens/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtthSinhVien ptthSinhVien = db.PtthSinhViens.Find(id);
            db.PtthSinhViens.Remove(ptthSinhVien);
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
