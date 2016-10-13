using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinaGO.Controllers
{
    public class InfoController : Controller
    {
        
        public ActionResult Info()
        {
            /* -- Vraca Basic Info view -- */
            return View("/Views/Info/Information.cshtml");
        }

        public ActionResult Geology()
        {
            return View("~/Views/Info/Geology.cshtml");
        }

        public ActionResult Archeology()
        {
            return View("~/Views/Info/Archeology.cshtml");
        }

        /*Database connection string*/
      /*  public ActionResult History()
        {
            HistoryContext db = new HistoryContext();
            return View(db.Histories.ToList());
        }
        */
        public ActionResult Geography()
        {
            return View("~/Views/Info/Geography.cshtml");
        }
    }
}