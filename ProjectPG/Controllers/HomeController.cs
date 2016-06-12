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
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        //GET:Home
        public ActionResult Index()
        {
            var random = db.Products.Where(r=> !r.noSeason).OrderBy(r=> Guid.NewGuid()).Take(4).ToList();


            var homeModel = new HomeViewModel()
            {
                RandomProducts = random
            };

            return View(homeModel);
        }

        //GET: Home
        public ActionResult Static(string staticname)
        {

            return View(staticname);

        }


    }
}