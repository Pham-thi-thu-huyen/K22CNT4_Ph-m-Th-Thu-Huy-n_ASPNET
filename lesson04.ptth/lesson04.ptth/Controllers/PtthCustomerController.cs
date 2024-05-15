using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson04.ptth.Models;

namespace lesson04.ptth.Controllers
{
    public class PtthCustomerController : Controller
    {
        // GET: PtthCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: PtthCustomerDetail
        public ActionResult PtthCustomerDetail()
        {
            //Tạo đối tượng dữ liệu
            var customer = new PtthCustomer()
            {
                CustomerId = 1,
                FirstName = "Phạm Thị Thu ",
                LastName = "Huyền",
                Address = "K22CNT4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();

        }
        //GET: PtthListCustomer
        public ActionResult PtthListCustomer()
        {
            var list = new List<PtthCustomer>()

            {
                new PtthCustomer()
                {
                     CustomerId = 1,
                FirstName = "Phạm Thị Thu ",
                LastName = "Huyền",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new PtthCustomer()
                {
                     CustomerId = 2,
                FirstName = "Nguyễn Thị Trà ",
                LastName = "Mi ",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new PtthCustomer()
                {
                     CustomerId = 3,
                FirstName = "Nguyễn Thị Trà ",
                LastName = "Mi 1",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new PtthCustomer()
                {
                     CustomerId = 4,
                FirstName = "Nguyễn Thị Trà ",
                LastName = "Mi 2",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
            };
            ViewBag.list = list; // Đưa đối tượng ra view bằng đối tượng ViewBag

            return View(list);
        }
        

    }
}