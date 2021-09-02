using gateway.api.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Depedencies
{
    public static class CommonDependencyResolver
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IJobRepo, JobRepository>();
            services.AddScoped<IRuleRepo, RuleRepository>();
            services.AddTransient<IStart, Start>();
            return services;
        }
    }
}
