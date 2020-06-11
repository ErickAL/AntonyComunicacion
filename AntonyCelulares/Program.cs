using AntonyCelulares.Data;
using AntonyCelulares.Views.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
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
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            /*services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });*/
            services.AddLogging(configure => configure.AddConsole());
            #region Views
            
            services.AddScoped<Form1>();
            //Account
            services.AddScoped<ListaUsuarioPage>();
            services.AddScoped<RegisterUsuarioPage>();
            services.AddScoped<LoginPage>();



            #endregion
        }
    }
}
