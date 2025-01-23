using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;

namespace WpfApp6.View.Pages
{

    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(Tbf.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask1Class myTask1Class = new MyTask1Class(Convert.ToDouble(TbY.Text), Convert.ToDouble(Tbf.Text));

                MessageBox.Show($"G = {myTask1Class.G()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                Tbf.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
