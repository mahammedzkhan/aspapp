﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeriesDB.Models
{
    public class Genre
    {
            public int Id { get; set; }
            
            public string Name { get; set; }

            [Display(ResourceType = typeof(LocalizedValues), Name = "GenreName")]
            public virtual ICollection<Serie> Series { get; set; }
        
    }
}