using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RainCheck.Startup))]
namespace RainCheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
