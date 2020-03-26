using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IACIS2020.Startup))]
namespace IACIS2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
