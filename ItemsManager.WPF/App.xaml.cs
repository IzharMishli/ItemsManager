using ItemsManager.WPF.Stores;
using ItemsManager.WPF.ViewModels;
using System.Windows;

namespace ItemsManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        public App()
        {
            
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
