using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CatchUpIAB330Service.Startup))]

namespace CatchUpIAB330Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}