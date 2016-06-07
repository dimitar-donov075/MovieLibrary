using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class TvSeries
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime AirDate { get; set; }
        public Int16 Season { get; set; }
        public Int16 Episode { get; set; }
        public string Rating { get; set; }

        public virtual ApplicationUser ApplicationUserId { get; set; }
    }
}