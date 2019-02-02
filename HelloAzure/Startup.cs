using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAzure.Startup))]
namespace HelloAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
