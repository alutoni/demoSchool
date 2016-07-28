using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(schoolDemo_01.Startup))]
namespace schoolDemo_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
