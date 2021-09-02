using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Models
{
    public class Microcontext : DbContext
    {
        public Microcontext()
        {

        }
        public Microcontext(DbContextOptions<Microcontext> options) : base(options)
        {
        }

        public DbSet<Job> Job { get; set; } //table name should be singular

      
        public DbSet<Rule> Rule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //Instantiates
            foreach (var foreignkey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignkey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}

