using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(job_ticket.Startup))]
namespace job_ticket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
