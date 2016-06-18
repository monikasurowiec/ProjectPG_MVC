using ProjectPG.ViewModels;
using ProjectPG.DAL;
using ProjectPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPG.Controllers
{
    public class OfferController : Controller
    { 

        private DatabaseContext db = new DatabaseContext();

        // GET: Offer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string productname)
        {
            return View();
        }



        public ActionResult List(string typename)
        {
            ViewBag.activeTypeName = typename;

            List<ProductType> listProductType = db.ProductTypes.ToList();
            listProductType.Add(
                new ProductType()
                {
                    typeName = "Wszystko",
                    typeUrlName = "wszystko",
                    typeDescription = "Wszystkie dania"
                });
            ViewBag.listProductType = listProductType;


            List<Product> listProduct = new List<Product>();
            if (typename == "wszystko")
            {
                listProduct = db.Products.ToList();
            }
            else
            {
                listProduct = db.Products.Where(l=>l.productType.typeUrlName==typename).ToList();
            }
            ViewBag.listProduct = listProduct;


            return View();
        }



        /* Api */
        public ActionResult AddOrder(int productId, int count)
        {

            SessionCart sessionCart = (SessionCart) Session["sessionCart"];

            int n = sessionCart.AddProduct(
                new OrderProduct()
                {
                    productId = productId,
                    count = count,
                    Product = db.Products.Where(p => p.productId == productId).Single()
                    }
                );


            Session["sessionCart"] = sessionCart;
            return Content(n.ToString()); ;
        }

        public ActionResult DeleteOrder(int productId)
        {

            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            sessionCart.DeleteProduct(
                new OrderProduct()
                {
                    productId = productId
                }
                );

            //sessionCart.SumTotalPrices

            Session["sessionCart"] = sessionCart;
            return Content("1"); ;
        }

        public ActionResult Cart()
        {
            SessionCart sessionCart = (SessionCart)Session["sessionCart"];
            ViewBag.productInCart = sessionCart.order.orderProduct;

            return View();
        }
    }
}
