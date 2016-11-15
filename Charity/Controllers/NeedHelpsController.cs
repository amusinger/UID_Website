using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Charity.Models;

namespace Charity.Controllers
{
      [Authorize]
    public class NeedHelpsController : Controller
    {
        private CharityContext db = new CharityContext();

      
        // GET: NeedHelps
        public ActionResult Index()
        {
            return View(db.NeedHelps.ToList());
        }

        // GET: NeedHelps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeedHelp needHelp = db.NeedHelps.Find(id);
            if (needHelp == null)
            {
                return HttpNotFound();
            }
            return View(needHelp);
        }

        // GET: NeedHelps/Create
        public ActionResult INeedHelp()
        {
            return View();
        }

        // POST: NeedHelps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult INeedHelp([Bind(Include = "NeedHelpId,FirstName,LastName,Phone,Message")] NeedHelp needHelp)
        {
            if (ModelState.IsValid)
            {
                db.NeedHelps.Add(needHelp);
                db.SaveChanges();
                return RedirectToAction("Thank", "Home");
            }

            return View(needHelp);
        }

        public ActionResult NeedConfirmed(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeedHelp needHelp = db.NeedHelps.Find(id);
            if (needHelp == null)
            {
                return HttpNotFound();
            }
            return View(needHelp);
        }

        // GET: NeedHelps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeedHelp needHelp = db.NeedHelps.Find(id);
            if (needHelp == null)
            {
                return HttpNotFound();
            }
            return View(needHelp);
        }

        // POST: NeedHelps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NeedHelpId,FirstName,LastName,Email,Phone,Message")] NeedHelp needHelp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(needHelp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(needHelp);
        }

        // GET: NeedHelps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeedHelp needHelp = db.NeedHelps.Find(id);
            if (needHelp == null)
            {
                return HttpNotFound();
            }
            return View(needHelp);
        }

        // POST: NeedHelps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NeedHelp needHelp = db.NeedHelps.Find(id);
            db.NeedHelps.Remove(needHelp);
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
