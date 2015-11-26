using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RajContoso.Startup))]
namespace RajContoso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
