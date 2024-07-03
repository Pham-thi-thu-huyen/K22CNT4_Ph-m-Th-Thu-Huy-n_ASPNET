using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtthK22CNT4Lesson10.Models;

namespace PtthK22CNT4Lesson10.Controllers
{
    public class PtthAccountsController : Controller
    {
        private PtthK22CNT4Lesson10Entities db = new PtthK22CNT4Lesson10Entities();

        // GET: PtthAccounts
        public ActionResult Index()
        {
            return View(db.PtthAccounts.ToList());
        }

        // GET: PtthAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthAccount ptthAccount = db.PtthAccounts.Find(id);
            if (ptthAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptthAccount);
        }

        // GET: PtthAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtthAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtthID,PtthUserName,PtthPassword,PtthFullName,PtthEmail,PtthPhone,PtthActive")] PtthAccount ptthAccount)
        {
            if (ModelState.IsValid)
            {
                db.PtthAccounts.Add(ptthAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptthAccount);
        }

        // GET: PtthAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthAccount ptthAccount = db.PtthAccounts.Find(id);
            if (ptthAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptthAccount);
        }

        // POST: PtthAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtthID,PtthUserName,PtthPassword,PtthFullName,PtthEmail,PtthPhone,PtthActive")] PtthAccount ptthAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptthAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptthAccount);
        }

        // GET: PtthAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtthAccount ptthAccount = db.PtthAccounts.Find(id);
            if (ptthAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptthAccount);
        }

        // POST: PtthAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtthAccount ptthAccount = db.PtthAccounts.Find(id);
            db.PtthAccounts.Remove(ptthAccount);
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
        //Login
        public ActionResult PtthLogin()
        {
            var ptthModel = new PtthAccount();
            return View(ptthModel);
        }
        [HttpPost]
        public ActionResult PtthLogin(PtthAccount ptthAccount)
        {
            var ptthCheck = db.PtthAccounts.Where(x => x.PtthUserName.Equals(ptthAccount.PtthUserName)
            && x.PtthPassword.Equals(ptthAccount.PtthPassword)).FirstOrDefault();
            if(ptthCheck !=null)
            {
                //Lưu session
                Session["PtthAccount"] = ptthCheck;
                return Redirect("/");
            }    
            return View(ptthAccount);
        }
    }
}
