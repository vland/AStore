﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;

namespace AStore.Controllers
{
    public class AboutController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public AboutController(IAstoreRepository repository)
        {
            _astoreRepository = repository;
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }
    }
}