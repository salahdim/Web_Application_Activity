using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Application_Activity.Startup))]
namespace Web_Application_Activity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
