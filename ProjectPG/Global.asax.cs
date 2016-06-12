using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ProjectPG.Models;

namespace ProjectPG
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            Order order = new Order()
            {
                orderId = new Guid(),
                orderProduct = new List<OrderProduct>()
            };

            Session["order"] = order;
        }
    }
}
