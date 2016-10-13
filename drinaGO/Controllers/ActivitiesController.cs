using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinaGO.Controllers
{
    public class ActivitiesController : Controller
    {
        // GET: Adventures
        public ActionResult Adventures()
        {
            return View("~/Views/Activities/Adventures.cshtml");
        }

        // GET: Festivals
        public ActionResult Festivals()
        {
            return View("~/Views/Activities/Festivals.cshtml");
        }

        // GET: Sport
        public ActionResult Sports()
        {
            return View("~/Views/Activities/Sports.cshtml");
        }

        // GET: Outdoors
        public ActionResult Outdoors()
        {
            return View("~/Views/Activities/Outdoors.cshtml");
        }

        // GET: Cycling
        public ActionResult Cycling()
        {
            return View("~/Views/Activities/Cycling.cshtml");
        }
    }
}