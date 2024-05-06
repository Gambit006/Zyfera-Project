using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Persistence
{
    public static class Registration
    {
        public static string ConnectionString;
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<API.Persistence.Context.AppContext>(conf =>
            {
                ConnectionString = configuration["ConnectionString"].ToString();
                conf.UseSqlServer(ConnectionString, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });


            return services;
        }
    }
}
