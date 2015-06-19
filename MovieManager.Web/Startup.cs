using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieManager.Web.Startup))]
namespace MovieManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
