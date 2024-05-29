using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ptth_BaiThiGiuaKy.Models;

namespace Ptth_BaiThiGiuaKy.Controllers
{
    public class PtthCustomerController : Controller
    {
        private static List<PtthCustormer> PtthCustormers = new List<PtthCustormer>()
        {
            new PtthCustormer {Ptth_2210900030_CustId = "2210900030",Ptth_FullName="Phạm Thị Thu Huyền", Ptth_Address="Thanh Hóa", 
                Ptth_Email="huyenphamthithu1202@gmail.com", Ptth_Phone="0343649641",Ptth_Balance=0},
             new PtthCustormer {Ptth_2210900030_CustId = "1",Ptth_FullName=" Thu Huyền", Ptth_Address="Thanh Hóa",
                Ptth_Email="huyenphamthithu1202@gmail.com", Ptth_Phone="0343649641",Ptth_Balance=1}
        }; 
        // GET: PtthCustomer
        public ActionResult PtthIndex()
        {
            return View(PtthCustormers);
        }
        //GET:PtthCreate
        public ActionResult PtthDetail()
        {
            var nttmCustomer = new PtthCustormer();
            return View(nttmCustomer);
        }
        [HttpPost]
        public ActionResult PtthDetail(PtthCustormer ptthCustomer)
        {
            // thêm mới đối tượng Customer vào danh sách 
            ptthCustomer.Add(PtthCustomer);
            // Chuyển về trang danh sách 
            return RedirectToAction("PtthIndex");
        }
        public ActionResult PtthDetail()
        {
            var ptthCustomer = new PtthCustormer();
            return View();
        }
        public ActionResult PtthEdit(string id)
        {
            var customer = PtthCustormers.FirstOrDefault(x => x.Ptth_2210900030_CustId == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult PtthEdit(PtthCustormer customer)
        {
            var nttmcus = PtthCustormers.FirstOrDefault(x => x.Ptth_2210900030_CustId == customer.Ptth_2210900030_CustId);
            // Sửa lại thông tin
            nttmcus.Ptth_2210900030_CustId = customer.Ptth_2210900030_CustId;
            nttmcus.Ptth_FullName = customer.Ptth_FullName;
            nttmcus.Ptth_Address = customer.Ptth_Address;
            nttmcus.Ptth_Email = customer.Ptth_Email;
            nttmcus.Ptth_Phone = customer.Ptth_Phone;
            nttmcus.Ptth_Balance = customer.Ptth_Balance;

            return RedirectToAction("PtthIndex");
        }
        public ActionResult PtthDelete(string id)
        {
            var customer = PtthCustormers.FirstOrDefault(x => x.Ptth_2210900030_CustId == id);
            // Xóa 
            PtthCustormers.Remove(customer);
            return RedirectToAction("PtthIndex");
        }
    }

}