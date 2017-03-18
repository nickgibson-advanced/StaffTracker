using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaffTracker.Startup))]
namespace StaffTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
