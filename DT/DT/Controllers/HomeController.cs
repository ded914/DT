﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DT.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Dynamic Text. © Igor Didenko, Andrej Didenko 1987-2016";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "";

            return View();
        }
    }
}