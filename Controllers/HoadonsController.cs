﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using qlks.Models;

namespace qlks.Controllers
{
    public class HoadonsController : Controller
    {
        private QLKSDbContext db = new QLKSDbContext();

        // GET: Hoadons
        public ActionResult Index()
        {
            return View(db.Hoadons.ToList());
        }

        // GET: Hoadons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadon hoadon = db.Hoadons.Find(id);
            if (hoadon == null)
            {
                return HttpNotFound();
            }
            return View(hoadon);
        }

        // GET: Hoadons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hoadons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaKH,SoTien,NgayTT,HinhThucTT")] Hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                db.Hoadons.Add(hoadon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hoadon);
        }

        // GET: Hoadons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadon hoadon = db.Hoadons.Find(id);
            if (hoadon == null)
            {
                return HttpNotFound();
            }
            return View(hoadon);
        }

        // POST: Hoadons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaKH,SoTien,NgayTT,HinhThucTT")] Hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoadon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hoadon);
        }

        // GET: Hoadons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadon hoadon = db.Hoadons.Find(id);
            if (hoadon == null)
            {
                return HttpNotFound();
            }
            return View(hoadon);
        }

        // POST: Hoadons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hoadon hoadon = db.Hoadons.Find(id);
            db.Hoadons.Remove(hoadon);
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
