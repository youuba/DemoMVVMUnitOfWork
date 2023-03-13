using DentalClinicManagement.Core.Interfaces;
using DentalClinicManagement.EF.Context;
using DentalClinicManagement.EF.Repositories;
using DentalClinicManagement.UI.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;
using DentalClinicManagement.UI.ViewModels;
using DentalClinicManagement.Core.Helpers;
using DentalClinicManagement.Core.Models;

namespace DentalClinicManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }
        public IServiceProvider ?ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(GetConnectionString()));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<PatientViewModel>();

            var serviceProvider = services.BuildServiceProvider();
            var window = new PatientWindow { DataContext = serviceProvider.GetService<PatientViewModel>() };
            ServiceProvider = serviceProvider;
            window.Show();
        }

        private string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("MyConnectionString");
        }
    }
}
