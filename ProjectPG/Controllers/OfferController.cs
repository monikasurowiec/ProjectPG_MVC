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
            return View();
        }

        [ChildActionOnly]
        public ActionResult ListMenu()
        {

            List<ProductType> typeNames = db.ProductTypes.ToList();
            
            //var typename = new ListMenuModel()
            //{
            //    Types = typeNames
            //}; 
            //return PartialView(typename);

            ViewBag.lista = typeNames;
            return PartialView();
        }
    }
}
