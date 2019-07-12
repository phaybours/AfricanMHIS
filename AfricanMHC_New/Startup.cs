using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AfricanMHC_New.Startup))]
namespace AfricanMHC_New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
