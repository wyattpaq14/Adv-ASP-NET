using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETINCLASSWEEK1.Startup))]
namespace ASPNETINCLASSWEEK1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
