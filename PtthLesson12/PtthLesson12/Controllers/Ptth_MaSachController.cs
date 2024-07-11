using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtthLesson12.Models;

namespace PtthLesson12.Controllers
{
    public class Ptth_MaSachController : Controller
    {
        private PhamThiThuHuyen_2210900030Entities db = new PhamThiThuHuyen_2210900030Entities();

        // GET: Ptth_MaSach
        public ActionResult PtthIndex()
        {
            return View(db.Ptth_MaSach.ToList());
        }

        // GET: Ptth_MaSach/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaSach ptth_MaSach = db.Ptth_MaSach.Find(id);
            if (ptth_MaSach == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaSach);
        }

        // GET: Ptth_MaSach/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: Ptth_MaSach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "Ptth_MaSach1,Ptth_TenSach,Ptth_Sotrang,Ptth_NamXB,Ptth_MaTG,Ptth_TrangThai")] Ptth_MaSach ptth_MaSach)
        {
            if (ModelState.IsValid)
            {
                db.Ptth_MaSach.Add(ptth_MaSach);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            return View(ptth_MaSach);
        }

        // GET: Ptth_MaSach/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaSach ptth_MaSach = db.Ptth_MaSach.Find(id);
            if (ptth_MaSach == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaSach);
        }

        // POST: Ptth_MaSach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "Ptth_MaSach1,Ptth_TenSach,Ptth_Sotrang,Ptth_NamXB,Ptth_MaTG,Ptth_TrangThai")] Ptth_MaSach ptth_MaSach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptth_MaSach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            return View(ptth_MaSach);
        }

        // GET: Ptth_MaSach/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaSach ptth_MaSach = db.Ptth_MaSach.Find(id);
            if (ptth_MaSach == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaSach);
        }

        // POST: Ptth_MaSach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ptth_MaSach ptth_MaSach = db.Ptth_MaSach.Find(id);
            db.Ptth_MaSach.Remove(ptth_MaSach);
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
