using ProjektPG.DAL;
using ProjektPG.Models;
//using ProjektPG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektPG.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        //GET:Home
        public ActionResult Index()
        {
            //ProductType newType = new ProductType { typeName = "Dżemy", typeDescription = "Mniam mniam dżemik" };
            //db.ProductTypes.Add(newType);
            //db.SaveChanges();

            var typesList = db.ProductTypes.ToList();

            return View();
        }

        //GET:Home
        public ActionResult Index2()
        {
            return View();
        }


        //private StoreContext db = new StoreContext();
        //// GET: Home
        //public ActionResult Index()
        //{
        //    var genres = db.Genres.ToList();

        //    var newArrivals = db.Albums.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();

        //    var bestsellers = db.Albums.Where(a => !a.IsHidden && a.IsBestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

        //    var vm = new HomeViewModel()
        //    {
        //        Bestsellers = bestsellers,
        //        Genres = genres,
        //        NewArrivals = newArrivals
        //    };

        //    return View(vm);

        //}
        //// GET: Home
        public ActionResult StaticContent(string viewname)
        {

            return View(viewname);

        }
    }
}