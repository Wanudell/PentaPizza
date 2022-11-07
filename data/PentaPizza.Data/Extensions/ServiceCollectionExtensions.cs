using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PentaPizza.Common;
using PentaPizza.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection($"{nameof(Settings)}:Database");
            var settings = section.Get<Settings.DatabaseSettings>();
            services.AddDbContext<PentaPizzaDbContext>(builder =>
            {
                builder.UseSqlServer(settings.ConnectionString);
            });
            services.AddScoped<DbContext, PentaPizzaDbContext>();
            return services;
        }
    }
}