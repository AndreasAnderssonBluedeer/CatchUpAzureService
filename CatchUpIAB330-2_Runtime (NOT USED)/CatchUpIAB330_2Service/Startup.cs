using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CatchUpIAB330_2Service.Startup))]

namespace CatchUpIAB330_2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}