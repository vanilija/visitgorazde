using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinaGO.Controllers
{
    public class LodgingController : Controller
    {
      /*  // GET: BedAndBreakfast
        public ActionResult BedAndBreakfast()
        {
            return View("~/Views/Lodging/BedAndBreakfast.cshtml");
        }
        
      */

        // GET: Camping
        public ActionResult Camping()
        {
            return View("~/Views/Lodging/Camping.cshtml");
        }

        // GET: Hostels

        public ActionResult Hostels()
        {
            return View("~/Views/Lodging/Hostels.cshtml");
        }

        // GET: Hotels 

        public ActionResult Hotels()
        {
            return View("~/Views/Lodging/Hotels.cshtml");
        }

        // GET: Motels

        public ActionResult Motels()
        {
            return View("~/Views/Lodging/Motels.cshtml");
        }
 
    }
}