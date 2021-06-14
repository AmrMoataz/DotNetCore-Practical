using BusinessLayer.Factories;
using BusinessLayer.Factories.Interfaces;
using BusinessLayer.ModelQueries;
using BusinessLayer.ModelQueries.Interfaces;
using BussinessenseCorpTest.Services;
using BussinessenseCorpTest.Services.Interfaces;
using DataLayer.Data.DBContext;
using DataLayer.Repository;
using DataLayer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopFront_End
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

        }
        private void ConfigureServices(ServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

            IConfiguration configuration = builder.Build();

            services.AddSingleton<MainWindow>(); 
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductFactory, ProductFactory>();
            services.AddScoped<IOrderFactory, OrderFactory>();
            services.AddScoped<IProductQuery, ProductQuery>();
            services.AddScoped<IOrderQuery, OrderQuery>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddDbContextPool<DBMainContext>(options => options.UseSqlServer(configuration.GetConnectionString("MainDBConnectionString")));

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        
    }
}
