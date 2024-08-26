using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MVC.Domain;

namespace MVC.Data
{
    public partial class MVCApplicationDbContext : IdentityDbContext
    {
        public MVCApplicationDbContext(DbContextOptions<MVCApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //remove warning for the save point disabled
            optionsBuilder.ConfigureWarnings(w => w.Ignore(SqlServerEventId.SavepointsDisabledBecauseOfMARS));
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}

