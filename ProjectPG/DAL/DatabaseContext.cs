using ProjectPG.DAL;
using ProjektPG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektPG.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("ConnectToDatabase")
        {

        }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new DatabaseInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}
         