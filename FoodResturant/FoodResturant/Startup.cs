using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodResturant.Startup))]
namespace FoodResturant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
