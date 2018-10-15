using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNewSite.Startup))]
namespace MyNewSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
