using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Villa_Suziriya.Startup))]
namespace Villa_Suziriya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
