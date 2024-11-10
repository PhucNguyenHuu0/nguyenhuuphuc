using NHPhuc_QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHPhuc_QuanLyBanHang.Controllers
{
    public class HomeController : Controller
    {
        private QuanLyBanHangEntities1 db = new QuanLyBanHangEntities1();
        public ActionResult Index()
        {
            var products = db.Hanghoa.ToList();

            // Nếu products là null hoặc không có sản phẩm, trả về một danh sách trống để tránh lỗi
            if (products == null || !products.Any())
            {
                products = new List<Hanghoa>();
            }

            return View(products);
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}