using AntonyCelulares.Data;
using AntonyCelulares.Views.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
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

            IHost host = Host.CreateDefaultBuilder()
             .ConfigureAppConfiguration((context, builder) =>
             {
                 // Add other configuration files...
                 builder.AddJsonFile("config.json", optional: true);
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
                 logging.AddConfiguration();
                 logging.AddConsole();
                 /*services.AddLogging(configure => configure.AddConsole());
                 services.AddLogging(configure => configure.AddConfiguration());*/
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
            #endregion
            #region Views
            services.AddSingleton<Form1>();
            //Account
            services.AddTransient<ListaUsuarioPage>();
            services.AddTransient<RegisterUsuarioPage>();
            services.AddTransient<LoginPage>();
            #endregion
            /**/


            //DataContext injection
            services.AddDbContext<DataContext>();

            using( var db=new DataContext())
            {
               var l= db.Usuarios.ToListAsync();
            }


        }
    }
}
