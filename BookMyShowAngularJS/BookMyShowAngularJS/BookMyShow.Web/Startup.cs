using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMyShow.Web.Startup))]
namespace BookMyShow.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
