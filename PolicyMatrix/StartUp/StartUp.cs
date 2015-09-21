using Microsoft.Owin;
using Owin;
using PolicyMatrix.StartUp;

[assembly: OwinStartup(typeof(StartUp))]
namespace PolicyMatrix.StartUp
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            
        } 
    }
}