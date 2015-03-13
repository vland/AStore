using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AStore.Core.Abstract;
using AStore.Models;

namespace AStore.Controllers
{
    public class ContactsController : Controller
    {
        private IAstoreRepository _astoreRepository;

        public ContactsController(IAstoreRepository repository)
        {
            this._astoreRepository = repository;
        }

        // GET: Contacts
        public ActionResult Contacts()
        {
            return View();
        }
    }
}