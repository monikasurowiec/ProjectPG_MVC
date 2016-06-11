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
            var types = new List<ProductType>
            {
                new ProductType()
                {
                     productTypeId=1,
                     typeName ="Dania mączne",
                     typeUrlName="dania-maczne",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     productTypeId=2,
                     typeName ="Dania mięsne",
                     typeUrlName="dania-miesne",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     productTypeId=3,
                     typeName ="Przetwory",
                     typeUrlName="przetwory",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
                new ProductType()
                {
                     productTypeId=4,
                     typeName ="Ciasta",
                     typeUrlName="ciasta",
                     typeDescription ="Tu w przyszłości będzie opis kategorii."
                },
   

            };
            types.ForEach(t => dataContext.ProductTypes.Add(t));
            dataContext.SaveChanges();
        
            var products = new List<Product>
            {
                new Product()
                {
                    productName="Pierogi z mięsem",
                    productUrlName="pierogi-z-miesem",
                    productDescription="Tu będzie opis produktu",
                    productPrice=18,
                    productCapacity=1000,
                    productPictureName="pierogi_mieso.jpg",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Pierogi z truskawkami",
                    productUrlName="pierogi-z-truskawkami",
                    productDescription="Tu będzie opis produktu",
                    productPrice=17,
                    productCapacity=1000,
                    productPictureName="pierogi_truskawki.jpg",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Kluski leniwe",
                    productUrlName="kluski-leniwe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=12,
                    productCapacity=1000,
                    productPictureName="leniwe.jpg",
                    productTypeId=1
                },
                new Product()
                {
                    productName="Devolaile",
                    productUrlName="devolaile",
                    productDescription="Tu będzie opis produktu",
                    productPrice=15,
                    productCapacity=500,
                    productPictureName="devolaile.jpg",
                    productTypeId=2
                },
                 new Product()
                {
                    productName="Kotlety schabowe",
                    productUrlName="kotlety-schabowe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=16,
                    productCapacity=500,
                    productPictureName="kotlet.jpg",
                    productTypeId=2
                },
                new Product()
                {
                    productName="Gulasz wołowy",
                    productUrlName="gulasz-wolowy",
                    productDescription="Tu będzie opis produktu",
                    productPrice=20,
                    productCapacity=500,
                    productPictureName="gulasz.jpg",
                    productTypeId=2
                },
                 new Product()
                {
                    productName="Zrazy wołowe",
                    productUrlName="zrazy-wolowe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=21,
                    productCapacity=500,
                    productPictureName="zrazy.jpg",
                    productTypeId=2
                },
                new Product()
                {
                    productName="Powidła śliwkowe",
                    productUrlName="powidla-sliwkowe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=5,
                    productCapacity=250,
                    productPictureName="powidla.jpg",
                    productTypeId=3
                },
                 new Product()
                {
                    productName="Dżem truskawkowy",
                    productUrlName="dzem-truskawkowy",
                    productDescription="Tu będzie opis produktu",
                    productPrice=7,
                    productCapacity=200,
                    productPictureName="dzem.jpg",
                    productTypeId=3
                },
                 new Product()
                {
                    productName="Kompot truskawkowy",
                    productUrlName="kompot-truskawkowy",
                    productDescription="Tu będzie opis produktu",
                    productPrice=9,
                    productCapacity=500,
                    productPictureName="kompot.jpg",
                    productTypeId=3
                },
                new Product()
                {
                    productName="Ciasto czekoladowe",
                    productUrlName="ciasto-czekoladowe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=18,
                    productCapacity=1000,
                    productPictureName="czekoladowe.jpg",
                    productTypeId=4
                },
                new Product()
                {
                    productName="Sernik z brzoskwiniami",
                    productUrlName="sernik-z-brzoskwiniami",
                    productDescription="Tu będzie opis produktu",
                    productPrice=22,
                    productCapacity=1000,
                    productPictureName="sernik.jpg",
                    productTypeId=4
                },
                new Product()
                {
                    productName="Ciasto jogurtowe z truskawkami",
                    productUrlName="ciasto-jogurtowe",
                    productDescription="Tu będzie opis produktu",
                    productPrice=17,
                    productCapacity=1000,
                    productPictureName="truskawkowe.jpg",
                    productTypeId=4
                },
                new Product()
                {
                    productName="Jabłecznik",
                    productUrlName="jablecznik",
                    productDescription="Tu będzie opis produktu",
                    productPrice=16,
                    productCapacity=1000,
                    productPictureName="jablecznik.jpg",
                    productTypeId=4
                },
            };
            products.ForEach(p => dataContext.Products.Add(p));
            dataContext.SaveChanges();

        }
        
    }
}