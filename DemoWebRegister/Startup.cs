using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebRegister.Startup))]
namespace DemoWebRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
