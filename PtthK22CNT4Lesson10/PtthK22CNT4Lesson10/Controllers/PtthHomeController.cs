using PtthK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtthK22CNT4Lesson10.Controllers
{
    public class PtthHomeController : Controller
    {
        public ActionResult PtthIndex()
        {
            //Kiểm dữ liệu trong session

            if(Session["PtthAccount"]!=null)
            {
                var ptthAccount = Session["PtthAccount"] as PtthAccount;
                ViewBag.FullName = ptthAccount.PtthFullName;
            }    
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