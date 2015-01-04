using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SeriesDB.Models;
using System.Diagnostics;
using Rotativa;


namespace SeriesDB.Controllers
{
    public class ActorsController : BaseController
    {
        private SerieContext db = new SerieContext();


       
        
        // GET: Actors
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "City" ? "city_desc" : "City";
            var actors = from a in db.Actors
                         select a;
            if (!String.IsNullOrEmpty(searchString))
            {
                actors = actors.Where(a => a.FirstName.Contains(searchString)
                                       || a.LastName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    actors = actors.OrderByDescending(a => a.FirstName);
                    break;
                case "City":
                    actors = actors.OrderBy(a => a.City);
                    break;
                case "city_desc":
                    actors = actors.OrderByDescending(s => s.City);
                    break;
                default:
                    actors = actors.OrderBy(a => a.FirstName);
                    break;
            }
            return View(actors.ToList());
        }
        public ActionResult PrintIndex()
        {
            //Code to get content
            return new Rotativa.ActionAsPdf("Index") { FileName = "TestActionAsPdf.pdf", CustomSwitches = "--print-media-type" };
        }
        // GET: Actors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            

            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        public ActionResult Linq()
        {
            var query = from p in db.Actors
            where p.LastName.Contains("a")
                        select new { FirstName = p.FirstName, LastName = p.LastName, BirthDate = p.BirthDate };
            var actors = query.ToList().Select(r => new Actor
             {
                FirstName = r.FirstName,
                LastName = r.LastName,
                BirthDate = r.BirthDate
             }).ToList();
            

    return View(actors);
        }

        // GET: Actors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,BirthDate,Street,ZipCode,City")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actor);
        }

        // GET: Actors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,BirthDate,Street,ZipCode,City")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        // GET: Actors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actor actor = db.Actors.Find(id);
            db.Actors.Remove(actor);
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
