﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tempest_test_1;

namespace Tempest_test_1.Controllers
{
    public class EMPsController : Controller
    {
        private EntityModel db = new EntityModel();

        // GET: EMPs
        public ActionResult Index()
        {
            return View(db.EMPs.ToList());
        }

        // GET: EMPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = db.EMPs.Find(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            return View(eMP);
        }

        // GET: EMPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Surname,Login")] EMP eMP)
        {
            if (ModelState.IsValid)
            {
                db.EMPs.Add(eMP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMP);
        }

        // GET: EMPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = db.EMPs.Find(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            return View(eMP);
        }

        // POST: EMPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,Login")] EMP eMP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMP);
        }

        // GET: EMPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = db.EMPs.Find(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            return View(eMP);
        }

        // POST: EMPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMP eMP = db.EMPs.Find(id);
            db.EMPs.Remove(eMP);
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
