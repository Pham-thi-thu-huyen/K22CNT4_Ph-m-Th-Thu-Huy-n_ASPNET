using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson06.ptth.Models;

namespace lesson06.ptth.Controllers
{
    public class PtthCategoriesController : Controller
    {
        private static PtthBookStore ptthDb;
        public PtthCategoriesController() 
        {
            ptthDb = new PtthBookStore();
        }
        // GET: PtthCategories
        public ActionResult PtthIndex()
        {
            /*
             * Khởi tạo DbContext:
             * EF sẽ tìm thông tin kết nối trong file machine .config của .NET Framework trên máy 
             * Và sau đó tạo csdl 
             * */
            //PtthBookStore ptthDb = new PtthBookStore();
            var ptthCategories = ptthDb.PtthCategories.ToList();
            return View(ptthCategories);

        }
        public ActionResult PtthCreate()
        {
            var ptthCategory = new PtthCategory();
                return View(ptthCategory);
        }
        [HttpPost]
        public ActionResult PtthCreate(PtthCategory ptthCategory)
        {
            ptthDb.PtthCategories.Add(ptthCategory);
            ptthDb.SaveChanges();
            return RedirectToAction("PtthIndex");
        }
    }
}