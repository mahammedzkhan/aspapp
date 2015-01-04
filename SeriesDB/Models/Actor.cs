using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeriesDB.Models
{
    public class Actor
    {
        public Actor()
        {
            Actors = new List<SelectListItem>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public IEnumerable<SelectListItem> Actors { get; set; }
        public virtual ICollection<Serie> Series { get; set; }

    }
}