using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MRBHub.Models.Common;

namespace MRBHub.Web.ORM
{
    public class MRBDbContext : DbContext
    {
        public DbSet<EntryPoint> EntryPoint { get; set; }

        public MRBDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(
          ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntryPoint>().HasKey(ep => new { ep.Pkid });
            base.OnModelCreating(modelBuilder);
        }
    }
}
