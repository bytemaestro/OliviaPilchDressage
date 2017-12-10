using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OliviaDressageWeb.Startup))]
namespace OliviaDressageWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
