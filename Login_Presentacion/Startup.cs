using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_Presentacion.Startup))]
namespace Login_Presentacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
