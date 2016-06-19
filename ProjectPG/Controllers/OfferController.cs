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
                listProduct = db.Products.Where(l => l.productType.typeUrlName == typename).ToList();
            }
            ViewBag.listProduct = listProduct;


            return View();
        }



        /* Api */
        public ActionResult AddOrder(int productId, int count)
        {

            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            int n = sessionCart.AddProduct(
                new OrderProduct()
                {
                    productId = productId,
                    count = count
                }
                );


            Session["sessionCart"] = sessionCart;
            return Content(n.ToString()); ;


        }
        public ActionResult AddOrderFromId(int productId)
        {

            SessionCart sessionCart = (SessionCart)Session["sessionCart"];
            int n = sessionCart.AddProduct(productId);
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

        //api
        public ActionResult Form(string firstName, string secondName, string email, string phone)
        {

            SessionCart sessionCart = (SessionCart)Session["sessionCart"];


            bool valid = Validation.FormValidation(firstName, secondName, email, phone);

            if (valid == true)
            {
                sessionCart.order.firstName = firstName;
                sessionCart.order.lastName = secondName;
                sessionCart.order.email = email;
                sessionCart.order.phone = phone;



                db.Orders.Add(sessionCart.order);
                foreach (var orderProduct in sessionCart.order.orderProduct)
                {
                    db.OrderProducts.Add(orderProduct);
                }
                db.SaveChanges();


            }
            //sessionCart.SumTotalPrices

            Session["sessionCart"] = sessionCart;
            return Content("1"); ;
        }

        public ActionResult Cart()
        {
            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            for (int n = 0; n < sessionCart.order.orderProduct.Count; n++)
            {
                int productId = sessionCart.order.orderProduct[n].productId;
                sessionCart.order.orderProduct[n].Product = db.Products.Where(p => p.productId == productId).Single();
            }

            ViewBag.productInCart = sessionCart.order.orderProduct;
            ViewBag.totalPrice = sessionCart.SumTotalPrices();
            return View();
        }
    }
}
