using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaOnlineMVC.MVC.Startup))]
namespace TiendaOnlineMVC.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
