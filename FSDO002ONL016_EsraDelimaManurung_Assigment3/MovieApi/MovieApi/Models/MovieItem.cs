using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class MovieItem
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Genre { get; set; }
        public string Duration{ get; set; }

        public Nullable <DateTime> ReleaseDate { get; set; }
    }
}
