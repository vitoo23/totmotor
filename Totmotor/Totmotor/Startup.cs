using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Totmotor.Startup))]
namespace Totmotor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
