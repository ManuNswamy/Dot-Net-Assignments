using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseTableDisplay.Startup))]
namespace DatabaseTableDisplay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
