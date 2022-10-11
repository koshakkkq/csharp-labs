using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rybakov.Startup))]
namespace Rybakov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
