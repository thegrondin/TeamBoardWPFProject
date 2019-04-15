using System.Windows;
using System.Windows.Navigation;
using MVVMCustomPresentation.Manager;
using MVVMCustomPresentation.ViewModels;

namespace MVVMCustomPresentation.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();

            //var userm = new UserManager();

            //_ = userm.GetAllUsersAsync();
        }
    }
}
