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

            Order order = (Order) Session["order"];

            OrderProduct product = new OrderProduct()
            {
                productId = productId,
                orderId = order.orderId,
                count = count
            };

            order.orderProduct.Add(product);

            Session["order"] = order;

            return Content("1"); ;
        }

    }
}
