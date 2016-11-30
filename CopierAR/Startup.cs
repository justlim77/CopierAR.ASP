using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CopierAR.Startup))]
namespace CopierAR
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
