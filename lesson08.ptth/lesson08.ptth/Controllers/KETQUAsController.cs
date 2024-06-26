using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lesson08.ptth.Models;

namespace lesson08.ptth.Controllers
{
    public class KETQUAsController : Controller
    {
        private PtthK22CNT4qlSinhVienEntities1 db = new PtthK22CNT4qlSinhVienEntities1();

        // GET: KETQUAs
        public ActionResult PtthIndex()
        {
            var kETQUAs = db.KETQUAs.Include(k => k.MONHOC).Include(k => k.SINHVIEN);
            return View(kETQUAs.ToList());
        }

        // GET: KETQUAs/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KETQUA kETQUA = db.KETQUAs.Find(id);
            if (kETQUA == null)
            {
                return HttpNotFound();
            }
            return View(kETQUA);
        }

        // GET: KETQUAs/Create
        public ActionResult PtthCreate()
        {
            ViewBag.PtthMaMH = new SelectList(db.MONHOCs, "PtthMaMH", "PtthTenMH");
            ViewBag.PtthMaSV = new SelectList(db.SINHVIENs, "PtthMaSV", "PtthHoSV");
            return View();
        }

        // POST: KETQUAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "PtthMaSV,PtthMaMH,PtthDiem")] KETQUA kETQUA)
        {
            if (ModelState.IsValid)
            {
                db.KETQUAs.Add(kETQUA);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            ViewBag.PtthMaMH = new SelectList(db.MONHOCs, "PtthMaMH", "PtthTenMH", kETQUA.PtthMaMH);
            ViewBag.PtthMaSV = new SelectList(db.SINHVIENs, "PtthMaSV", "PtthHoSV", kETQUA.PtthMaSV);
            return View(kETQUA);
        }

        // GET: KETQUAs/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KETQUA kETQUA = db.KETQUAs.Find(id);
            if (kETQUA == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtthMaMH = new SelectList(db.MONHOCs, "PtthMaMH", "PtthTenMH", kETQUA.PtthMaMH);
            ViewBag.PtthMaSV = new SelectList(db.SINHVIENs, "PtthMaSV", "PtthHoSV", kETQUA.PtthMaSV);
            return View(kETQUA);
        }

        // POST: KETQUAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtthMaSV,PtthMaMH,PtthDiem")] KETQUA kETQUA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kETQUA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PtthMaMH = new SelectList(db.MONHOCs, "PtthMaMH", "PtthTenMH", kETQUA.PtthMaMH);
            ViewBag.PtthMaSV = new SelectList(db.SINHVIENs, "PtthMaSV", "PtthHoSV", kETQUA.PtthMaSV);
            return View(kETQUA);
        }

        // GET: KETQUAs/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KETQUA kETQUA = db.KETQUAs.Find(id);
            if (kETQUA == null)
            {
                return HttpNotFound();
            }
            return View(kETQUA);
        }

        // POST: KETQUAs/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KETQUA kETQUA = db.KETQUAs.Find(id);
            db.KETQUAs.Remove(kETQUA);
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
