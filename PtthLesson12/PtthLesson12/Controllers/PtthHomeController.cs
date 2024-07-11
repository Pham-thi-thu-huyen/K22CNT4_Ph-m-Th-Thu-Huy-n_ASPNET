using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtthLesson12.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}