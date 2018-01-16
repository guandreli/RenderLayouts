using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RenderLayout {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Sobre",
                url: "sobre/",
                defaults: new { controller = "Sobre", action = "Sobre", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home Admin",
                url: "admin/",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new [] { "RenderLayout.Areas.Admin" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new [] {"RenderLayout.Controllers"}
            );
        }
    }
}
