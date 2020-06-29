using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularAspNet
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var origen = ConfigurationManager.AppSettings["origen"];
            var cors = new EnableCorsAttribute(origen, "*", "*");
            config.EnableCors(cors);

            //rutaas web api
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
