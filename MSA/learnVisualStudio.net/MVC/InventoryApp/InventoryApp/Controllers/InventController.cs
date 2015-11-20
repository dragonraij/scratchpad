using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class InventController : Controller
    {
        private InventotyEntities db = new InventotyEntities();

        // GET: Invent
        public ActionResult Index()
        {
            return View(db.Invents.ToList());
        }

        // GET: Invent/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invent invent = db.Invents.Find(id);
            if (invent == null)
            {
                return HttpNotFound();
            }
            return View(invent);
        }

        // GET: Invent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Quantity")] Invent invent)
        {
            if (ModelState.IsValid)
            {
                invent.Id = Guid.NewGuid();
                db.Invents.Add(invent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invent);
        }

        // GET: Invent/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invent invent = db.Invents.Find(id);
            if (invent == null)
            {
                return HttpNotFound();
            }
            return View(invent);
        }

        // POST: Invent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Quantity")] Invent invent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invent);
        }

        // GET: Invent/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invent invent = db.Invents.Find(id);
            if (invent == null)
            {
                return HttpNotFound();
            }
            return View(invent);
        }

        // POST: Invent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Invent invent = db.Invents.Find(id);
            db.Invents.Remove(invent);
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
