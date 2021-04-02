using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week_4_Assignment.Models;

namespace Week_4_Assignment.Data
{
    public class Week_4_AssignmentContext : DbContext
    {
        public Week_4_AssignmentContext (DbContextOptions<Week_4_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Week_4_Assignment.Models.Movie> Movie { get; set; }
    }
}
