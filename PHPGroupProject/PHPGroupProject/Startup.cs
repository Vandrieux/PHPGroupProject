using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PHPGroupProject.Startup))]
namespace PHPGroupProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
