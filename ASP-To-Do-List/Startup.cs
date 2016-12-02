using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_To_Do_List.Startup))]
namespace ASP_To_Do_List
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
