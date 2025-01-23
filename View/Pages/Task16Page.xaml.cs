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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }
        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbT.Text) && string.IsNullOrEmpty(TbR.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask16Class myTask16Class = new MyTask16Class(Convert.ToDouble(TbT.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbR.Text));

                MessageBox.Show($"W = {myTask16Class.W()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbT.Text = string.Empty;
                TbR.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
