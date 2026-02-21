using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using EAH.Libs;
using EAH.ViewModels;

namespace EAH
{
    public partial class App : Application
    {
        public IServiceProvider? Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // rejestracje
            services.AddSingleton<INPVCalc, LibNPVCalc>();
            services.AddTransient<ViewModels.MainWindowViewModel>();
            services.AddTransient<ViewModels.NpvWindowViewModel>();

            // rejestracja widoków (Window) aby umożliwić wstrzyknięcie ViewModeli
            services.AddTransient<MainWindow>();
            services.AddTransient<NPVWindow>();

            Services = services.BuildServiceProvider();

            var main = Services.GetRequiredService<MainWindow>();
            main.Show();

            base.OnStartup(e);
        }
    }
}