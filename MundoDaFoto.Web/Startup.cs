using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MundoDaFoto.Web.Startup))]
namespace MundoDaFoto.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
