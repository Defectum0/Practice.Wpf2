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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }
        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbT.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask25Class myTask25Class = new MyTask25Class(Convert.ToDouble(TbC.Text), Convert.ToDouble(TbT.Text));

                MessageBox.Show($"L = {myTask25Class.L()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbC.Text = string.Empty;
                TbT.Text = string.Empty;
            }
        }
    }
}
