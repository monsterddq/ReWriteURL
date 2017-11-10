using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ReWriteURL.Models
{
    public class ProductDBInitializer : CreateDatabaseIfNotExists<ProductDBContext>
    {
        protected override void Seed(ProductDBContext context)
        {
            context.categories.Add(new Category("Cate1", "Pizza", 1));
            context.categories.Add(new Category("Cate2", "My", 2));
            context.categories.Add(new Category("Cate3", "Tea", 3));
            context.products.Add(new Product("Prod1", "Pizza1", "1000"));
            context.products.Add(new Product("Prod2", "My1", "2000"));
            context.products.Add(new Product("Prod3", "Tea1", "3000"));
            context.products.Add(new Product("Prod4", "My2", "4000"));
            context.products.Add(new Product("Prod5", "Tea2", "5000"));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}