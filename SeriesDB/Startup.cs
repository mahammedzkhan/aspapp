using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeriesDB.Startup))]
namespace SeriesDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
