using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjectPG.DAL;
using ProjectPG.Models;
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
            var types = new List<ProductType>
            {
                new ProductType()
                {
                     ProductTypeId=1,
                     TypeName ="Dania mączne",
                     TypeUrlName="dania-maczne",
                     TypeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     ProductTypeId=2,
                     TypeName ="Dania mięsne",
                     TypeUrlName="dania-miesne",
                     TypeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     ProductTypeId=3,
                     TypeName ="Przetwory",
                     TypeUrlName="przetwory",
                     TypeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     ProductTypeId=4,
                     TypeName ="Ciasta",
                     TypeUrlName="ciasta",
                     TypeDescription ="Tu w przyszłości będzie opis kategorii."
                },
   

            };
            types.ForEach(t => dataContext.ProductTypes.Add(t));
            dataContext.SaveChanges();
        
            var products = new List<Product>
            {
                new Product() 
                {
                    ProductName="Pierogi z mięsem",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=18.99m,
                    ProductCapacity=1000,
                    ProductPictureName="pierogi_mieso.jpg",
                    ProductTypeId=1
                },
                new Product()
                {
                    ProductName="Pierogi z truskawkami",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=14.90m,
                    ProductCapacity=1000,
                    ProductPictureName="pierogi_truskawki.jpg",
                    ProductTypeId=1
                },
                new Product()
                {
                    ProductName="Kluski leniwe",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=12.50m,
                    ProductCapacity=1000,
                    ProductPictureName="leniwe.jpg",
                    ProductTypeId=1
                },
                new Product()
                {
                    ProductName="Devolaile",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=15.00m,
                    ProductCapacity=500,
                    ProductPictureName="devolaile.jpg",
                    ProductTypeId=2
                },
                 new Product()
                {
                    ProductName="Kotlety schabowe",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=16.00m,
                    ProductCapacity=500,
                    ProductPictureName="kotlet.jpg",
                    ProductTypeId=2
                },
                new Product()
                {
                    ProductName="Gulasz wołowy",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=20.10m,
                    ProductCapacity=500,
                    ProductPictureName="gulasz.jpg",
                    ProductTypeId=2
                },
                 new Product()
                {
                    ProductName="Zrazy wołowe",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=19.90m,
                    ProductCapacity=500,
                    ProductPictureName="zrazy.jpg",
                    ProductTypeId=2
                },
                new Product()
                {
                    ProductName="Powidła śliwkowe",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=5.05m,
                    ProductCapacity=250,
                    ProductPictureName="powidla.jpg",
                    ProductTypeId=3
                },
                 new Product()
                {
                    ProductName="Dżem truskawkowy",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=6.90m,
                    ProductCapacity=200,
                    ProductPictureName="dzem.jpg",
                    ProductTypeId=3
                },
                 new Product()
                {
                    ProductName="Kompot truskawkowy",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=7.80m,
                    ProductCapacity=500,
                    ProductPictureName="kompot.jpg",
                    ProductTypeId=3
                },
                new Product()
                {
                    ProductName="Ciasto czekoladowe",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=18.09m,
                    ProductCapacity=1000,
                    ProductPictureName="czekoladowe.jpg",
                    ProductTypeId=4
                },
                new Product()
                {
                    ProductName="Sernik z brzoskwiniami",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=21.90m,
                    ProductCapacity=1000,
                    ProductPictureName="sernik.jpg",
                    ProductTypeId=4
                },
                new Product()
                {
                    ProductName="Ciasto jogurtowe z truskawkami",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=17.99m,
                    ProductCapacity=1000,
                    ProductPictureName="truskawkowe.jpg",
                    ProductTypeId=4
                },
                new Product()
                {
                    ProductName="Jabłecznik",
                    ProductDescription="Tu będzie opis produktu",
                    ProductPrice=16.60m,
                    ProductCapacity=1000,
                    ProductPictureName="jablecznik.jpg",
                    ProductTypeId=4
                },
            };
            products.ForEach(p => dataContext.Products.Add(p));
            dataContext.SaveChanges();

        }
        
    }
}