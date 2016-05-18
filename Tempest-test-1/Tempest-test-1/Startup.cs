using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tempest_test_1.Startup))]
namespace Tempest_test_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
