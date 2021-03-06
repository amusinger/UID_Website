﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.Controllers
{
    public class HomeController : Controller
    {
        private CharityContext db = new CharityContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HowWeHelp()
        {
            var money = db.CanHelps.Sum(x => x.Amount);
             

            ViewBag.Message = money;
            return View();
        }

        public ActionResult Thank()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}