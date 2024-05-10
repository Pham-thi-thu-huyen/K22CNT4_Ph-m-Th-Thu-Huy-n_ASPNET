using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson02.ptth.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Huyền Phạm - 2210900030";
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}