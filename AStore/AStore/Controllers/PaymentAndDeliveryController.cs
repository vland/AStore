using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;

namespace AStore.Controllers
{
    public class PaymentAndDeliveryController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public PaymentAndDeliveryController(IAstoreRepository repository)
        {
            _astoreRepository = repository;
        }

        // GET: PaymentAndDelivery
        public ActionResult PaymentAndDelivery()
        {
            return View();
        }
    }
}