using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ReWriteURL.Models
{
    public class ProductDBContext : DbContext
    {
        public virtual DbSet<Category> categories { get; set; }
        public virtual DbSet<Product> products { get; set; }

        public ProductDBContext():base()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}