using EmployeesDemoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeesDemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            EmployeesDemoApp.MainWindow window = new MainWindow();
            EmployeeViewModel empViewModel = new EmployeeViewModel();
            window.DataContext = empViewModel;
            window.Show();
        }
    }
}
