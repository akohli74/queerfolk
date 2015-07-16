using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(queerfolk.Startup))]
namespace queerfolk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
