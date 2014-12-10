using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeriesDB.Models
{
    public class SerieViewModel
    {
        [StringLength(50)]
        public string Name { get; set; }

        public int SelectedGenreId { get; set; }

        public List<SelectListItem> Genres { get; set; }

    }
}