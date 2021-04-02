using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_4_Assignment.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
}
