using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Visionet.CatatanWebsite.Models;

namespace Visionet.CatatanWebsite.DAL
{
    public class CatatanContext : DbContext
    {
        public DbSet<User> UserModels { get; set; }
        public DbSet<Catatan> CatatanModels { get; set; }

        public CatatanContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CatatanContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}