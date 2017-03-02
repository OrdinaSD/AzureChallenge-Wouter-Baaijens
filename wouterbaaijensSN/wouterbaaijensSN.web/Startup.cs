using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wouterbaaijensSN.web.Startup))]
namespace wouterbaaijensSN.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
