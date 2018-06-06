using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GitBuild.Data;
using GitBuild.Domain;

namespace GitBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection));
                services.AddSingleton(typeof(IRepository<>));
        }
    }
}
