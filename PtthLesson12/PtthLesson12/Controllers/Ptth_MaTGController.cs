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
    public class Ptth_MaTGController : Controller
    {
        private PhamThiThuHuyen_2210900030Entities db = new PhamThiThuHuyen_2210900030Entities();

        // GET: Ptth_MaTG
        public ActionResult PtthIndex()
        {
            return View(db.Ptth_MaTG.ToList());
        }

        // GET: Ptth_MaTG/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaTG ptth_MaTG = db.Ptth_MaTG.Find(id);
            if (ptth_MaTG == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaTG);
        }

        // GET: Ptth_MaTG/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: Ptth_MaTG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "Ptth_MaTG1,Ptth_TenTG")] Ptth_MaTG ptth_MaTG)
        {
            if (ModelState.IsValid)
            {
                db.Ptth_MaTG.Add(ptth_MaTG);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            return View(ptth_MaTG);
        }

        // GET: Ptth_MaTG/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaTG ptth_MaTG = db.Ptth_MaTG.Find(id);
            if (ptth_MaTG == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaTG);
        }

        // POST: Ptth_MaTG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "Ptth_MaTG1,Ptth_TenTG")] Ptth_MaTG ptth_MaTG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptth_MaTG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            return View(ptth_MaTG);
        }

        // GET: Ptth_MaTG/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptth_MaTG ptth_MaTG = db.Ptth_MaTG.Find(id);
            if (ptth_MaTG == null)
            {
                return HttpNotFound();
            }
            return View(ptth_MaTG);
        }

        // POST: Ptth_MaTG/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ptth_MaTG ptth_MaTG = db.Ptth_MaTG.Find(id);
            db.Ptth_MaTG.Remove(ptth_MaTG);
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
