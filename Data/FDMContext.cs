using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Authorization;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Data
{
    public class FDMContext: IdentityDbContext<AppUser>
    {
        public FDMContext():base("name=FDMData")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Athlete> AthleteDbSet { get; set; }
        public DbSet<Sport> SportDbSet { get; set; }
        public DbSet<Coach> CoachDbSet { get; set; }
        public DbSet<Worker> WorkerDbse { get; set; }

        public static FDMContext Create()
        {
            return new FDMContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }

    }
}
