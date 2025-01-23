using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;

namespace WpfApp6.View.Pages
{
    
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double F = 3.5 * Math.Pow(TbD,2) + 1) / Math.Cos(2 * TbY);
                MyTask2Class myTask2Class = new MyTask2Class(Convert.ToDouble(TbY.Text), Convert.ToDouble(TbD.Text));

                MessageBox.Show($"F = {myTask2Class.F()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbD.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
