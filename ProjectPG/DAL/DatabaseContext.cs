﻿using ProjectPG.DAL;
using ProjectPG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectPG.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
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
        public object Product { get; internal set; }
    }

}
         