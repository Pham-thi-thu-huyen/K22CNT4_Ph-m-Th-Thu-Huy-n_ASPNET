using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson04.ptth.Models;

namespace lesson04.ptth.Controllers
{
    public class PtthCustomerScaffdingController : Controller
    {
        //mockdata
        private List<PtthCustomer> PtthCustomer = new List<PtthCustomer>()
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
    
        
        // GET: PtthCustomerScaffding
        // listcustomer
        public ActionResult Index()
        {
        return View(List Custome);
        }
        [HttpGet]
        public ActionResult PtthCreat()
        {
            var model = new PtthCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult PtthCreat(PtthCustomer model)
        {

            List Customer.Add(model);
            return View(model);
        }
    }
}