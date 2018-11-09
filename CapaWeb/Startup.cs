using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapaWeb.Startup))]
namespace CapaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
