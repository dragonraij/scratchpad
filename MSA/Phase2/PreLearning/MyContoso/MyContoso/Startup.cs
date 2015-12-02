using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyContoso.Startup))]
namespace MyContoso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
