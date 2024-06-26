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
    public class MONHOCsController : Controller
    {
        private PtthK22CNT4qlSinhVienEntities1 db = new PtthK22CNT4qlSinhVienEntities1();

        // GET: MONHOCs
        public ActionResult PtthIndex()
        {
            return View(db.MONHOCs.ToList());
        }

        // GET: MONHOCs/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // GET: MONHOCs/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: MONHOCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtthMaMH,PtthTenMH,PtthSoTiet")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.MONHOCs.Add(mONHOC);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            return View(mONHOC);
        }

        // GET: MONHOCs/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // POST: MONHOCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "PtthMaMH,PtthTenMH,PtthSoTiet")] MONHOC mONHOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mONHOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            return View(mONHOC);
        }

        // GET: MONHOCs/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONHOC mONHOC = db.MONHOCs.Find(id);
            if (mONHOC == null)
            {
                return HttpNotFound();
            }
            return View(mONHOC);
        }

        // POST: MONHOCs/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MONHOC mONHOC = db.MONHOCs.Find(id);
            db.MONHOCs.Remove(mONHOC);
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
