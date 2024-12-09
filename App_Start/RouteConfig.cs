using System.Web.Mvc;
using System.Web.Routing;

namespace CalculatorApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Define the default route for Calculator/Index
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Calculator", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
