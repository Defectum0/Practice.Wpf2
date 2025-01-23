using System.Windows;
using WpfApp6.Core;
using WpfApp6.View.Pages;

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainNavigation.MainFrameNav = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
