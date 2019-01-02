using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinderRev2.Startup))]
namespace TinderRev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
