using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureGrooming.Startup))]
namespace AzureGrooming
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
