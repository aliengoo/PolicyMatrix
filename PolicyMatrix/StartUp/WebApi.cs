using System.Web.Http;
using Owin;

namespace PolicyMatrix.StartUp
{
    public class WebApi
    {
        public static void Register(IAppBuilder app, HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new
            {
                id = RouteParameter.Optional
            });

            app.UseWebApi(config);
        } 
    }
}