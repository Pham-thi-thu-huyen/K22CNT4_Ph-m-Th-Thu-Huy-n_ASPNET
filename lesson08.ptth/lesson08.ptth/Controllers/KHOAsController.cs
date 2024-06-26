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
    public class KHOAsController : Controller
    {
        private PtthK22CNT4qlSinhVienEntities1 db = new PtthK22CNT4qlSinhVienEntities1();

        // GET: KHOAs
        public ActionResult Index()
        {
            //return View(db.KHOAs.ToList());
            return View(db.KHOAs.ToList());
        }
        public ActionResult PtthIndex()
        {
            //return View(db.KHOAs.ToList());
            return View(db.KHOAs.ToList());
        }

        // GET: KHOAs/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.KHOAs.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // GET: KHOAs/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: KHOAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "PtthMaKH,PtthTenKH")] KHOA kHOA)
        {
            if (ModelState.IsValid)
            {
                db.KHOAs.Add(kHOA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kHOA);
        }

        // GET: KHOAs/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.KHOAs.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // POST: KHOAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "PtthMaKH,PtthTenKH")] KHOA kHOA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kHOA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            return View(kHOA);
        }

        // GET: KHOAs/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOA kHOA = db.KHOAs.Find(id);
            if (kHOA == null)
            {
                return HttpNotFound();
            }
            return View(kHOA);
        }

        // POST: KHOAs/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KHOA kHOA = db.KHOAs.Find(id);
            db.KHOAs.Remove(kHOA);
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
