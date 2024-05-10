using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson03.ptth.Controllers
{
    public class PTThStudentController : Controller
    {
        // GET: PTThStudent
        public ActionResult Index()
        {
            //dữ liệu từ ViewData
            ViewData["msg"] = "ViewData - Phạm Thị Thu Huyền";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            //Sử dụng ViewBag
            //Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Phạm Thị Thu Huyền";

            //Giá trị là một tập hợp
            string[] names = { "Huy Hoàng", "Trần Mai", "Hồng Sơn" };
            ViewBag.list = names;

            // giá trị là một đối tượng 
            var obj = new
            {
                ID = 100,
                Name = "Huyền Huyền",
                Age = 20
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}