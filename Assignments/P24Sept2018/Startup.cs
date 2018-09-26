using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P24Sept2018.Startup))]
namespace P24Sept2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
