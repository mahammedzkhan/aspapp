using SeriesDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeriesDB.Controllers
{
    public class OverzichtController : Controller
    {
        // GET: Overzicht
        public ActionResult Index()
        {
            var SerieContext = new SerieContext();
            return View();
        }
        public ActionResult Create()
        {
            var context = new SerieContext();
            var viewModel = new SerieViewModel();
            viewModel.Genres = new List<SelectListItem>();
            viewModel.Genres.Add(new SelectListItem() { Text = "Selecteer een genre" });
            foreach (var genre in context.Genres)
            {
                viewModel.Genres.Add(new SelectListItem
                {
                    Text = genre.Name,
                    Value = genre.Id.ToString(),
                    Selected = false
                });
            }


            return View(viewModel);
        }
    }
}