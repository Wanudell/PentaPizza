using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Context
{
    public class DesignDbContext : IDesignTimeDbContextFactory<PentaPizzaDbContext>
    {
        public PentaPizzaDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                            .SetBasePath(System.IO.Path.Combine(Directory.GetCurrentDirectory()))
                            .AddJsonFile("appsettings.json", false, true).Build()
                            .GetValue<string>("MigrationConnectionString");

            var optionBuilder = new DbContextOptionsBuilder<PentaPizzaDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new PentaPizzaDbContext(optionBuilder.Options);
        }
    }
}