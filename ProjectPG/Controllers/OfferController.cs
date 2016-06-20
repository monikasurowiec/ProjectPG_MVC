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


        //GET:Offer
        public ActionResult List(string typename)
        {
            ViewBag.activeTypeName = typename;

            List<ProductType> listProductType = db.ProductTypes.ToList();
            listProductType.Add(
                new ProductType()
                {
                    TypeName = "Wszystko",
                    TypeUrlName = "wszystko",
                    TypeDescription = "Wszystkie dania"
                });
            ViewBag.listProductType = listProductType;

            List<Product> listProduct = new List<Product>();
            if (typename == "wszystko")
            {
                listProduct = db.Products.ToList();
            }
            else
            {
                listProduct = db.Products.Where(l => l.ProductType.TypeUrlName == typename).ToList();
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
                    ProductId = productId,
                    Count = count
                }
                );

            Session["sessionCart"] = sessionCart;
            return Content(n.ToString()); ;
        }


        /* Api */
        public ActionResult AddOrderFromId(int productId)
        {
            SessionCart sessionCart = (SessionCart)Session["sessionCart"];
            int n = sessionCart.AddProduct(productId);
            Session["sessionCart"] = sessionCart;

            return Content(n.ToString()); ;
        }


        /* Api */
        public ActionResult DeleteOrder(int productId)
        {
            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            sessionCart.DeleteProduct(
                new OrderProduct()
                {
                    ProductId = productId
                }
                );

            Session["sessionCart"] = sessionCart;
            return Content("1"); ;
        }


        /* Api */
        public ActionResult Form(string firstName, string secondName, string email, string phone)
        {

            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            bool valid = Validation.FormValidation(firstName, secondName, email, phone);

            if (valid == true)
            {
                sessionCart.order.FirstName = firstName;
                sessionCart.order.LastName = secondName;
                sessionCart.order.Email = email;
                sessionCart.order.Phone = phone;

                db.Orders.Add(sessionCart.order);
                foreach (var orderProduct in sessionCart.order.OrderProduct)
                {
                    db.OrderProducts.Add(orderProduct);
                }
                db.SaveChanges();

            }

            Session["sessionCart"] = sessionCart;
            return Content("1"); ;
        }


        //GET:Offer
        public ActionResult Cart()
        {
            SessionCart sessionCart = (SessionCart)Session["sessionCart"];

            for (int n = 0; n < sessionCart.order.OrderProduct.Count; n++)
            {
                int productId = sessionCart.order.OrderProduct[n].ProductId;
                sessionCart.order.OrderProduct[n].Product = db.Products.Where(p => p.ProductId == productId).Single();
            }

            ViewBag.productInCart = sessionCart.order.OrderProduct;
            ViewBag.totalPrice = sessionCart.SumTotalPrices();
            return View();
        }
    }
}
