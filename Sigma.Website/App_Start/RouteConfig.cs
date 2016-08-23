using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sigma.Website
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            MapSubdomainRoute(
                routes,
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
        }
        public static void MapSubdomainRoute(this RouteCollection routes, string name, string url, object defaults = null, object constraints = null)
        {
            routes.Add(name, new SubdomainRoute(url)
            {
                Defaults = new RouteValueDictionary(defaults),
                Constraints = new RouteValueDictionary(constraints),
                DataTokens = new RouteValueDictionary()
            });
        }
    }
}
