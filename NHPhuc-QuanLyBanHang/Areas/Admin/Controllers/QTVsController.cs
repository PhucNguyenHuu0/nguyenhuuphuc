using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NHPhuc_QuanLyBanHang.Models;

namespace NHPhuc_QuanLyBanHang.Areas.Admin.Controllers
{
    public class QTVsController : Controller
    {
        private QuanLyBanHangEntities1 db = new QuanLyBanHangEntities1();

        // GET: Admin/QTVs
        public ActionResult Index()
        {
            var qTV = db.QTV.Include(q => q.User);
            return View(qTV.ToList());
        }

        // GET: Admin/QTVs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QTV qTV = db.QTV.Find(id);
            if (qTV == null)
            {
                return HttpNotFound();
            }
            return View(qTV);
        }

        // GET: Admin/QTVs/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.User, "UserID", "Username");
            return View();
        }

        // POST: Admin/QTVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Username,Password")] QTV qTV)
        {
            if (ModelState.IsValid)
            {
                db.QTV.Add(qTV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.User, "UserID", "Username", qTV.UserID);
            return View(qTV);
        }

        // GET: Admin/QTVs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QTV qTV = db.QTV.Find(id);
            if (qTV == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.User, "UserID", "Username", qTV.UserID);
            return View(qTV);
        }

        // POST: Admin/QTVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Username,Password")] QTV qTV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qTV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.User, "UserID", "Username", qTV.UserID);
            return View(qTV);
        }

        // GET: Admin/QTVs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QTV qTV = db.QTV.Find(id);
            if (qTV == null)
            {
                return HttpNotFound();
            }
            return View(qTV);
        }

        // POST: Admin/QTVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QTV qTV = db.QTV.Find(id);
            db.QTV.Remove(qTV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
