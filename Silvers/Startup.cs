using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Silvers.Startup))]
namespace Silvers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
