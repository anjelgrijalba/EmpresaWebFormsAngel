using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PresentacionWebForms.Startup))]
namespace PresentacionWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
