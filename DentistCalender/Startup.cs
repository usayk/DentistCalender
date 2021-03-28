using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistCalender.Startup))]
namespace DentistCalender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
