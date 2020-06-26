using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Iwenli.IdentityServer4.Admin.EntityFramework.Shared.DbContexts;
using Iwenli.IdentityServer4.STS.Identity.Helpers;

namespace Iwenli.IdentityServer4.STS.Identity.Configuration.Test
{
    public class StartupTest : Startup
    {
        public StartupTest(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
        {
        }

        public override void RegisterDbContexts(IServiceCollection services)
        {
            services.RegisterDbContextsStaging<AdminIdentityDbContext, IdentityServerConfigurationDbContext, IdentityServerPersistedGrantDbContext>();
        }
    }
}





