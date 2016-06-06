using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieLibrary.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace MovieLibrary.Controllers
{
    [Authorize]
    public class TvSeriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /TvSeries/
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var seriesByUser = db.TvSeries.Where(c => c.ApplicationUserId.Id == id);
            return View(seriesByUser.ToList());
        }

        // GET: /TvSeries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvSeries tvseries = db.TvSeries.Find(id);
            if (tvseries == null)
            {
                return HttpNotFound();
            }
            return View(tvseries);
        }

        // GET: /TvSeries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TvSeries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Title,Genre,AirDate,Season,Episode")] TvSeries tvseries)
        {
            if (ModelState.IsValid)
            {
                var id = User.Identity.GetUserId();
                tvseries.ApplicationUserId = db.Users.Find(id);
                db.TvSeries.Add(tvseries);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tvseries);
        }

        // GET: /TvSeries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvSeries tvseries = db.TvSeries.Find(id);
            if (tvseries == null)
            {
                return HttpNotFound();
            }
            return View(tvseries);
        }

        // POST: /TvSeries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Title,Genre,AirDate,Season,Episode")] TvSeries tvseries)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tvseries).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tvseries);
        }

        // GET: /TvSeries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvSeries tvseries = db.TvSeries.Find(id);
            if (tvseries == null)
            {
                return HttpNotFound();
            }
            return View(tvseries);
        }

        // POST: /TvSeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TvSeries tvseries = db.TvSeries.Find(id);
            db.TvSeries.Remove(tvseries);
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
