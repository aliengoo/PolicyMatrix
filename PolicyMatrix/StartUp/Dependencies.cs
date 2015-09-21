using System.Web.Http;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace PolicyMatrix.StartUp
{
    public class Dependencies
    {
        public static void Register(HttpConfiguration config)
        {
            var c = new UnityContainer();

            config.DependencyResolver = new UnityDependencyResolver(c);

            // TODO: Add dependencies here
        } 
    }
}