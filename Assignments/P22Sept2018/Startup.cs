using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P22Sept2018.Startup))]
namespace P22Sept2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }



    }
}
