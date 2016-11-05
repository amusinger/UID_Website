using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Charity.Startup))]
namespace Charity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
