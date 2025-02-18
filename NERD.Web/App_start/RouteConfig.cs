﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NERD.Web.App_start
{
    public class RouteConfig
    {
        
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.MapRoute(null, "Page{page}",
                new
                {
                    controller = "Product",
                    action = "List",
                    category =
                        (string)null
                },
                new { page = @"\d+" }
                );
                routes.MapRoute(null,
                "{category}",
                new { controller = "Product", action = "List", page = 1 }
                );
                routes.MapRoute(null,
                "{category}/Page{page}",
                new { controller = "Product", action = "List" },
                new { page = @"\d+" }
                );
                routes.MapRoute(null, "{controller}/{action}");

                routes.MapRoute(
                "Images",
                "{controller}/{action}/{id}/{name}",
                new { controller = "Product", action = "GetMainPicture", id = UrlParameter.Optional },
                new[] { "mynamespace.Controllers" }
            );


                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            }
        }
    
}