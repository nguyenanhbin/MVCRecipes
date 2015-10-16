using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20Recipes.Startup))]
namespace _20Recipes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
