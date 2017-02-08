using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternetApp.Startup))]
namespace InternetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
