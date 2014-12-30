using SeriesDB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesDB.Models;

namespace SeriesDB.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SessionPagina(SessionModel info)
        {
            Session["UserId"] = info.UserName;
            return RedirectToAction("UserSessionSection");
        }

        public ActionResult UserSessionSection()
        {
            var Data_session = new SessionModel();

            try
            {
                if ((Object)Session["UserId"] != null)
                    Data_session.Session_Val = "Welcome " + Session["UserId"].ToString();
                else
                    Data_session.Session_Val = "Session has expired.";
            }
            catch (Exception)
            {
            }

            return View(Data_session);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        } 
    }
}