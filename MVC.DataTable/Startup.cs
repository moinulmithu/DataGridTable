using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.DataTable.Startup))]
namespace MVC.DataTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
