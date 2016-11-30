using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MET.WEB.UI.Startup))]
namespace MET.WEB.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
