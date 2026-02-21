using EAH.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EAH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider _services;
        public MainWindow(MainWindowViewModel vm, IServiceProvider services)
        {
            InitializeComponent();
            DataContext = vm;
            _services = services;
        }

        private void NPVButtonClick(object sender, RoutedEventArgs e)
        {
            var npv = _services.GetRequiredService<NPVWindow>();
            npv.Owner = this;
            npv.Show();
        }
    }
}