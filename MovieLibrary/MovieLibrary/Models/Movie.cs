﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime DateOfWatching { get; set; }
        public string Rating { get; set; }

        public virtual ApplicationUser ApplicationUserId { get; set; }

    }
}