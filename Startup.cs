using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Guarderia.Startup))]
namespace Guarderia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
