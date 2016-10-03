using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21_NDV2.Models;

namespace Lab21_NDV2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Response guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to party organizer
                return View("thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }


        }
        public ViewResult ResponseForm()
        {
            return View();
        }
    }
   
}
