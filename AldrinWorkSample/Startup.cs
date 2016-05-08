using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AldrinWorkSample.Startup))]
namespace AldrinWorkSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
