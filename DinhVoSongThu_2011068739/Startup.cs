using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DinhVoSongThu_2011068739.Startup))]
namespace DinhVoSongThu_2011068739
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
