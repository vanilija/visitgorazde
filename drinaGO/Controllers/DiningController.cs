using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinaGO.Controllers
{
    public class DiningController : Controller
    {
        // GET: Restaurants
        public ActionResult Restaurants()
        {
            return View("~/Views/Dining/Restaurants.cshtml");
        }

        // GET: Coffee

        public ActionResult Cafe()
        {
            return View("~/Views/Dining/Cafe.cshtml");
        }
    }
}