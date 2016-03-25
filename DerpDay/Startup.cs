using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DerpDay.Startup))]
namespace DerpDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
