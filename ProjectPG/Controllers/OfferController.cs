using ProjectPG.ViewModels;
using ProjektPG.DAL;
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

            var typeNames = db.ProductTypes.ToList();

            var typename = new ListMenuModel()
            {
                Types = typeNames
            };

            return PartialView(typename);
        }
    }
}
