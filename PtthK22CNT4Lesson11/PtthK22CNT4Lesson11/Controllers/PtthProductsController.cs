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
    public class PtthProductsController : Controller
    {
        private PtthK22CNT4Lesson11DbEntities db = new PtthK22CNT4Lesson11DbEntities();

        // GET: PtthProducts
        public ActionResult PtthIndex()
        {
            return View(db.PtthProducts.ToList());
        }

        // GET: PtthProducts/Details/5
        public ActionResult PtthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthProduct ptthProduct = db.PtthProducts.Find(id);
            if (ptthProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptthProduct);
        }

        // GET: PtthProducts/Create
        public ActionResult PtthCreate()
        {
            return View();
        }

        // POST: PtthProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthCreate([Bind(Include = "Ptthid2210900030,PtthProName,PtthQty,PtthPrice,PtthCateId,PtthActive")] PtthProduct ptthProduct)
        {
            if (ModelState.IsValid)
            {
                db.PtthProducts.Add(ptthProduct);
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }

            return View(ptthProduct);
        }

        // GET: PtthProducts/Edit/5
        public ActionResult PtthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthProduct ptthProduct = db.PtthProducts.Find(id);
            if (ptthProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptthProduct);
        }

        // POST: PtthProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtthEdit([Bind(Include = "Ptthid2210900030,PtthProName,PtthQty,PtthPrice,PtthCateId,PtthActive")] PtthProduct ptthProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtthIndex");
            }
            return View(ptthProduct);
        }

        // GET: PtthProducts/Delete/5
        public ActionResult PtthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthProduct ptthProduct = db.PtthProducts.Find(id);
            if (ptthProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptthProduct);
        }

        // POST: PtthProducts/Delete/5
        [HttpPost, ActionName("PtthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtthProduct ptthProduct = db.PtthProducts.Find(id);
            db.PtthProducts.Remove(ptthProduct);
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
