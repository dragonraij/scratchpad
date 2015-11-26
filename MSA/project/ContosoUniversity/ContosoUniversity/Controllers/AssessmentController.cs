using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class AssessmentController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Assessment
        public ActionResult Index()
        {
            return View(db.Assessments.ToList());
        }

        // GET: Assessment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assessment assessment = db.Assessments.Find(id);
            if (assessment == null)
            {
                return HttpNotFound();
            }
            return View(assessment);
        }

        // GET: Assessment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assessment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssessmentID,SubmissionType,TotalMarks,Weight,DueDate")] Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                db.Assessments.Add(assessment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assessment);
        }

        // GET: Assessment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assessment assessment = db.Assessments.Find(id);
            if (assessment == null)
            {
                return HttpNotFound();
            }
            return View(assessment);
        }

        // POST: Assessment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssessmentID,SubmissionType,TotalMarks,Weight,DueDate")] Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assessment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assessment);
        }

        // GET: Assessment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assessment assessment = db.Assessments.Find(id);
            if (assessment == null)
            {
                return HttpNotFound();
            }
            return View(assessment);
        }

        // POST: Assessment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assessment assessment = db.Assessments.Find(id);
            db.Assessments.Remove(assessment);
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
