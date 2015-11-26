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
    public class StudentAssessmentController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: StudentAssessment
        public ActionResult Index()
        {
            return View(db.StudentAssessments.ToList());
        }

        // GET: StudentAssessment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssessment studentAssessment = db.StudentAssessments.Find(id);
            if (studentAssessment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssessment);
        }

        // GET: StudentAssessment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentAssessment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentAssessmentID,SubmissionTime,Marks,SubmissionLink")] StudentAssessment studentAssessment)
        {
            if (ModelState.IsValid)
            {
                db.StudentAssessments.Add(studentAssessment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentAssessment);
        }

        // GET: StudentAssessment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssessment studentAssessment = db.StudentAssessments.Find(id);
            if (studentAssessment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssessment);
        }

        // POST: StudentAssessment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentAssessmentID,SubmissionTime,Marks,SubmissionLink")] StudentAssessment studentAssessment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAssessment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentAssessment);
        }

        // GET: StudentAssessment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssessment studentAssessment = db.StudentAssessments.Find(id);
            if (studentAssessment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssessment);
        }

        // POST: StudentAssessment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAssessment studentAssessment = db.StudentAssessments.Find(id);
            db.StudentAssessments.Remove(studentAssessment);
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
