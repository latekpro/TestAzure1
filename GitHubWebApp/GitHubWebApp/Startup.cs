using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubWebApp.Startup))]
namespace GitHubWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
