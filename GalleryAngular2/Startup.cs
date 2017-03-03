using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GalleryAngular2.Startup))]
namespace GalleryAngular2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
