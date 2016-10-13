using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(drinaGO.Startup))]
namespace drinaGO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
