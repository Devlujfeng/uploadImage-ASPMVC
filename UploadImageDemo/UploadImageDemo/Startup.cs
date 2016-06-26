using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadImageDemo.Startup))]
namespace UploadImageDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
