using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjektPG.DAL;
using ProjektPG.Models;
using System.Data.Entity.Migrations;

namespace ProjectPG.DAL
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext dataContext)
        {
            SeedData(dataContext);
            base.Seed(dataContext);
        }

        private void SeedData(DatabaseContext dataContext)
        {
            List<ProductType> types = new List<ProductType>
            {
                new ProductType()
                {
                     productTypeId=1,
                     typeName ="Konfitury",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     productTypeId=2,
                     typeName ="Musy",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     productTypeId=3,
                     typeName ="Kompoty",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                 new ProductType()
                {
                     productTypeId=3,
                     typeName ="Pikle",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
            };

            types.ForEach(t => dataContext.ProductTypes.Add(t));
            dataContext.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product()
                {
                    productName="Konfitura wiśniowa",
                    productDescription="Tu będzie opis produktu",
                    productPrice=6,
                    productCapacity=250,
                    productPictureName="cherry.png",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Konfitura truskawkowa",
                    productDescription="Tu będzie opis produktu",
                    productPrice=5,
                    productCapacity=250,
                    productPictureName="cherry.png",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Konfitura śliwkowa",
                    productDescription="Tu będzie opis produktu",
                    productPrice=7,
                    productCapacity=250,
                    productPictureName="cherry.png",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Konfitura jagodowa",
                    productDescription="Tu będzie opis produktu",
                    productPrice=7,
                    productCapacity=200,
                    productPictureName="cherry.png",
                    productTypeId=1
                },
            };
            products.ForEach(p => dataContext.Products.Add(p));
            dataContext.SaveChanges();

        }
        
    }
}