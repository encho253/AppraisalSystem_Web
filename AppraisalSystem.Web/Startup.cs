using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppraisalSystem.Web.Startup))]
namespace AppraisalSystem.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
        }
    }
}