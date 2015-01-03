using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeriesDB.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<Serie> Series { get; set; }

    }
}