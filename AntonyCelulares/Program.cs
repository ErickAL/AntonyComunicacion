using AntonyCelulares.Data;
using AntonyCelulares.Data.Entities;
using AntonyCelulares.Helpers;
using AntonyCelulares.Interfaces;
using AntonyCelulares.Views.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntonyCelulares
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        private static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            IServiceCollection services = new ServiceCollection();
            IConfiguration configuration;

            var host = Host.CreateDefaultBuilder()
             .ConfigureAppConfiguration((context, builder) =>
             {
                 // Add other configuration files...
                 builder.AddJsonFile("appsettings.json", optional: true);
             })
             .ConfigureServices((context, _services) =>
             {
                 configuration = context.Configuration;
                 services = _services;
                 ConfigureServices(context.Configuration, services);
             })
             .ConfigureLogging(logging =>
             {
                 // Add other loggers...
             })
             .Build();

            

            //ConfigureServices(configuration, services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Form1 form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        /// <summary>
        /// Method for injecting dependency
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            #region Helpers
            services.AddScoped<IUserHelper, UserHelper>();
            #endregion
            #region Views
            services.AddScoped<Form1>();
            //Account
            services.AddScoped<ListaUsuarioPage>();
            services.AddScoped<RegisterUsuarioPage>();
            services.AddScoped<LoginPage>();
            #endregion
            /**/
            services.AddLogging(configure => configure.AddConsole());
            services.AddLogging(configure => configure.AddConfiguration());

            //DataContext injection
            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }); 



        }
    }
}
