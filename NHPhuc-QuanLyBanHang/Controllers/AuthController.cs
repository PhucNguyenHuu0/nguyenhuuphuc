using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NHPhuc_QuanLyBanHang.Models;
using Newtonsoft.Json;
using System.Configuration;
using System.Security.Principal;
using System.Web.Security;
namespace NHPhuc_QuanLyBanHang.Controllers
{
    public class AuthController : Controller
    {
        private QuanLyBanHangEntities1 db = new QuanLyBanHangEntities1();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

    }
}
