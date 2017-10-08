using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyASP2.Startup))]
namespace UdemyASP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
