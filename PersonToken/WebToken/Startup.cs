using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebToken.Startup))]
namespace WebToken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
