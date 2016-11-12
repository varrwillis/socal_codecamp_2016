using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(socal_codecamp_2016.Startup))]
namespace socal_codecamp_2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
