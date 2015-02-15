using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;

namespace AStore.Controllers
{
    public class HomeController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public HomeController(IAstoreRepository repository)
        {
            _astoreRepository = repository;
        }

        // GET: Home
        public ViewResult Index()
        {
            var data = _astoreRepository.Products.ToList();
            return View();
        }
    }
}