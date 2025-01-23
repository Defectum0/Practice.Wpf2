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
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }
        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbQ.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask19Class myTask19Class = new MyTask19Class(Convert.ToDouble(TbQ.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"E = {myTask19Class.E()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbQ.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}