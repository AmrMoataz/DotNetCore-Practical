using DataLayer.Data.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();


            var builder = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

            IConfiguration configuration = builder.Build();

            services.AddDbContextPool<DBMainContext>(options => options.UseSqlServer(configuration.GetConnectionString("MainDBConnectionString")));
            services.AddTransient<EntryPoint>();


            return services;
        }
    }
}
