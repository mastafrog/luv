using System.Linq;
using System.Web.Http;

namespace Luv
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// Web API configuration and services
			config.EnableSystemDiagnosticsTracing();


			// Web API routes
			config.MapHttpAttributeRoutes();
			/*config.Formatters.JsonFormatter.SupportedMediaTypes
                  .Add(new MediaTypeHeaderValue("text/html"));
             */

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );








			var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

		}
    }
}