
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AldrinWorkSample.Startup))]
namespace AldrinWorkSample
{
    public partial class Startup
    {
        private void ConfigureAuth(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}