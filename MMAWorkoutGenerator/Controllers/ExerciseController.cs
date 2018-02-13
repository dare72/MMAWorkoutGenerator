using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MMAWorkoutGenerator.Models;

namespace MMAWorkoutGenerator.Controllers
{
    public class ExerciseController : Controller
    {
        private ExercisesEntities db = new ExercisesEntities();

        // GET: Exercise
        public ActionResult Index()
        {
            return View(db.EXERCISES.ToList());
        }

        // GET: Exercise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXERCIS eXERCIS = db.EXERCISES.Find(id);
            if (eXERCIS == null)
            {
                return HttpNotFound();
            }
            return View(eXERCIS);
        }

        // GET: Exercise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "exerciseID,exerciseName,exerciseDesc")] EXERCIS eXERCIS)
        {
            if (ModelState.IsValid)
            {
                db.EXERCISES.Add(eXERCIS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eXERCIS);
        }

        // GET: Exercise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXERCIS eXERCIS = db.EXERCISES.Find(id);
            if (eXERCIS == null)
            {
                return HttpNotFound();
            }
            return View(eXERCIS);
        }

        // POST: Exercise/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "exerciseID,exerciseName,exerciseDesc")] EXERCIS eXERCIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eXERCIS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eXERCIS);
        }

        // GET: Exercise/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EXERCIS eXERCIS = db.EXERCISES.Find(id);
            if (eXERCIS == null)
            {
                return HttpNotFound();
            }
            return View(eXERCIS);
        }

        // POST: Exercise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EXERCIS eXERCIS = db.EXERCISES.Find(id);
            db.EXERCISES.Remove(eXERCIS);
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
