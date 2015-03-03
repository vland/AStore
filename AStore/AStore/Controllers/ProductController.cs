using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;
using AStore.Models;

namespace AStore.Controllers
{
    public class ProductController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public ProductController(IAstoreRepository repository)
        {
            this._astoreRepository = repository;
        }

        public ViewResult List(string category, int page = 1)
        {
            var model = new ProductViewModel
            {
                CategoryName = category,
                Products = _astoreRepository.Products.Where(x => x.Categories.Name == category).ToList()
            };
            return View(model);
        }
    }
}