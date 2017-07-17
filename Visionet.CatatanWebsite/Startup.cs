using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Visionet.CatatanWebsite.Startup))]
namespace Visionet.CatatanWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
