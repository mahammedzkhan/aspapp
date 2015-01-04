using SeriesDB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SeriesDB.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult SwitchLanguage(string language)
        {
            Session.Add("taal", language);
            return RedirectToAction("Index");
        }
    }
}