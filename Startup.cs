using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rehber.Startup))]
namespace Rehber
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
