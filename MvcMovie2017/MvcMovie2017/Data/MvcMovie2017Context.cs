using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie2017.Models
{
    public class MvcMovie2017Context : DbContext
    {
        public MvcMovie2017Context (DbContextOptions<MvcMovie2017Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie2017.Models.Movie> Movie { get; set; }
    }
}
