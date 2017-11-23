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
    public class FDMContext: IdentityDbContext<AppUser, MyRole, int, MyLogin, MyUserRole, MyClaim>
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

            modelBuilder.Entity<MyLogin>().HasKey<int>(l => l.UserId);
            modelBuilder.Entity<MyRole>().HasKey<int>(r => r.Id);
            modelBuilder.Entity<MyUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }

    }
}
