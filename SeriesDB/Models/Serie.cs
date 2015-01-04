using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeriesDB.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Foreign Key
        public int GenreId { get; set; }
        public int ActorId { get; set; }
    }
}