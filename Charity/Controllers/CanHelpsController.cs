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
    public class CanHelpsController : Controller
    {
        private CharityContext db = new CharityContext();

        // GET: CanHelps
        public ActionResult Index()
        {
            return View(db.CanHelps.ToList());
        }

        // GET: CanHelps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CanHelps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CanHelpId,FirstName,LastName,Email,CreditCard,CV,Amount")] CanHelp canHelp)
        {
            if (ModelState.IsValid)
            {
                db.CanHelps.Add(canHelp);
                db.SaveChanges();
                return RedirectToAction("DonateConfirmed", new { id = canHelp.CanHelpId });
            }

            return View(canHelp);
        }

        public ActionResult DonateConfirmed(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CanHelp canHelp = db.CanHelps.Find(id);
            if (canHelp == null)
            {
                return HttpNotFound();
            }
            return View(canHelp);
        }


        // GET: CanHelps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CanHelp canHelp = db.CanHelps.Find(id);
            if (canHelp == null)
            {
                return HttpNotFound();
            }
            return View(canHelp);
        }

       
        // GET: CanHelps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CanHelp canHelp = db.CanHelps.Find(id);
            if (canHelp == null)
            {
                return HttpNotFound();
            }
            return View(canHelp);
        }

        // POST: CanHelps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CanHelpId,FirstName,LastName,Email,CreditCard,CV,Amount")] CanHelp canHelp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(canHelp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(canHelp);
        }

        // GET: CanHelps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CanHelp canHelp = db.CanHelps.Find(id);
            if (canHelp == null)
            {
                return HttpNotFound();
            }
            return View(canHelp);
        }

        // POST: CanHelps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CanHelp canHelp = db.CanHelps.Find(id);
            db.CanHelps.Remove(canHelp);
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
