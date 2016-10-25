using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CatchUp3Service.Startup))]

namespace CatchUp3Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}