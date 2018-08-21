using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhyWhere.Startup))]
namespace WhyWhere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
