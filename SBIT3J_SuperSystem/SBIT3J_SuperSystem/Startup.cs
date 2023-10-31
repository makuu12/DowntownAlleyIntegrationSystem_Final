using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBIT3J_SuperSystem.Startup))]
namespace SBIT3J_SuperSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
