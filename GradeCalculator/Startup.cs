using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradeCalculator.Startup))]
namespace GradeCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
