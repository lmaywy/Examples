using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examples.MVC.Startup))]
namespace Examples.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
