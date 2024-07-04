using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtthK22CNT4Lesson11.Controllers
{
    public class PtthHomeController : Controller
    {
        public ActionResult PtthIndex()
        {
            return View();
        }

        public ActionResult PtthAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PtthContact()
        {
            ViewBag.msv = "2210900030";
            ViewBag.fullname = "Phạm Thị Thu Huyền";

            return View();
        }
    }
}