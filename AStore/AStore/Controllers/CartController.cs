using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AStore.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ViewResult Cart()
        {
            return View();
        }
    }
}