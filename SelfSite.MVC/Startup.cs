using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfSite.MVC.Startup))]
namespace SelfSite.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
