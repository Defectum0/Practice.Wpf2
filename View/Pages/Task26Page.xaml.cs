using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Task26Page.xaml
    /// </summary>
    public partial class Task26Page : Page
    {
        public Task26Page()
        {
            InitializeComponent();
        }
        private void BtnTask26_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbU.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask26Class myTask26Class = new MyTask26Class(Convert.ToDouble(TbU.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"T = {myTask26Class.T()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbU.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
