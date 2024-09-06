using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheBestApp.Models;

namespace TheBestApp.Data
{
    public class TheBestAppContext : DbContext
    {
        public TheBestAppContext (DbContextOptions<TheBestAppContext> options)
            : base(options)
        {
        }

        public DbSet<TheBestApp.Models.Person> Person { get; set; } = default!;
    }
}
