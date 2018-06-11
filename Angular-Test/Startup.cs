using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_Test.Startup))]
namespace Angular_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
