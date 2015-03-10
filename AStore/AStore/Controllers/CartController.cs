using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;
using AStore.Core.Concrete;
using AStore.Core.Helpers;
using AStore.Models;

namespace AStore.Controllers
{
    public class CartController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public CartController(IAstoreRepository repository)
        {
            _astoreRepository = repository;
        }

        // GET: Cart
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            var product = _astoreRepository.Products.FirstOrDefault(x => x.Id == productId);
            if (product != null)
            {
                GetCart().AddItem(product, 1);
            }
            // TODO: maybe will change this part to avoid redirection
            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            var product = _astoreRepository.Products.FirstOrDefault(x => x.Id == productId);
            if (product != null)
            {
                // TODO: implement to remove more then 1 item
                GetCart().RemoveProduct(product, -1);
            }
            // TODO: maybe will change this part to avoid redirection
            return RedirectToAction("Index", new {returnUrl});
        }

        private Cart GetCart()
        {
            var cart = (Cart) Session[StaticData.SessionCartKey];
            if (cart == null)
            {
                cart = new Cart();
                Session[StaticData.SessionCartKey] = cart;
            }
            return cart;
        }
    }
}