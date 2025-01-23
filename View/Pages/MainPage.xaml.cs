using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Core;

namespace WpfApp6.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTask_Click(object sender, RoutedEventArgs e)
        {
            int sw = Convert.ToInt32(NumTask.Text);
            NavigationToPage navigationTo = new NavigationToPage(sw);
            navigationTo.SwitchPage();
        }
    }
}
