using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public IActionResult Index()
        {
            return View(this.contactRepository.GetContacts());
        }

        public IActionResult Details(int ID)
        {

            var contactResult = this.contactRepository.GetByID(ID);

            if (contactResult is null)
            {
                return RedirectToAction("Index", "Contact");
            }

            return View(contactResult);
        }

        
    }
}

