using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;

namespace AStore.Controllers
{
    public class NavController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public NavController(IAstoreRepository repository)
        {
            _astoreRepository = repository;
        }

        // GET: Nav
        public PartialViewResult Menu()
        {
            return PartialView();
        }
    }
}