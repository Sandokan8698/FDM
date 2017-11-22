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
using Domain.Entities;


namespace Data
{
    public class FDMContext: DbContext
    {
        public FDMContext():base("name=FDMData")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Athlete> AthleteDbSet { get; set; }
        public DbSet<Sport> SportDbSet { get; set; }
        public DbSet<Coach> CoachDbSet { get; set; }
        public DbSet<User> UserDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }

    }
}
