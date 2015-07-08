using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIUMentorWebApp.Startup))]
namespace SIUMentorWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
