using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMCVProject.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathinfo}");
        }

    }
}