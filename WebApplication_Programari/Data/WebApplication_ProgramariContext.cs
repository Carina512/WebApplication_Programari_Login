using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Data
{
    public class WebApplication_ProgramariContext : DbContext
    {
        public WebApplication_ProgramariContext (DbContextOptions<WebApplication_ProgramariContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_Programari.Models.Programare> Programare { get; set; } = default!;

        public DbSet<WebApplication_Programari.Models.Doctor>? Doctor { get; set; }

        public DbSet<WebApplication_Programari.Models.Review>? Review { get; set; }
    }
}
