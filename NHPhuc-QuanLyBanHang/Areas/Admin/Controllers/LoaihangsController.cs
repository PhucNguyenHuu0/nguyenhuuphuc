﻿using System;
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
    public class LoaihangsController : Controller
    {
        private QuanLyBanHangEntities1 db = new QuanLyBanHangEntities1();

        // GET: Admin/Loaihangs
        public ActionResult Index()
        {
            return View(db.Loaihang.ToList());
        }

        // GET: Admin/Loaihangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaihang loaihang = db.Loaihang.Find(id);
            if (loaihang == null)
            {
                return HttpNotFound();
            }
            return View(loaihang);
        }

        // GET: Admin/Loaihangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Loaihangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Maloai,Tenloai")] Loaihang loaihang)
        {
            if (ModelState.IsValid)
            {
                db.Loaihang.Add(loaihang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaihang);
        }

        // GET: Admin/Loaihangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaihang loaihang = db.Loaihang.Find(id);
            if (loaihang == null)
            {
                return HttpNotFound();
            }
            return View(loaihang);
        }

        // POST: Admin/Loaihangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Maloai,Tenloai")] Loaihang loaihang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaihang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaihang);
        }

        // GET: Admin/Loaihangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaihang loaihang = db.Loaihang.Find(id);
            if (loaihang == null)
            {
                return HttpNotFound();
            }
            return View(loaihang);
        }

        // POST: Admin/Loaihangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Loaihang loaihang = db.Loaihang.Find(id);
            db.Loaihang.Remove(loaihang);
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
