using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectPG
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProductDetails",
                url: "{productname}.html",
                defaults: new { controller = "Offer", action = "Details" }
                );

            routes.MapRoute(
                name: "StaticPages",
                url: "{staticname}.html",
                defaults: new { controller = "Home", action = "Static" }
                );

            routes.MapRoute(
                name: "ProductList",
                url: "produkty/{typename}",
                defaults: new { controller = "Offer", action = "List" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}