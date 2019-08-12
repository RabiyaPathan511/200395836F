using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395836F.Startup))]
namespace _200395836F
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
