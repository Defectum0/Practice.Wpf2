using System.Windows;
using System;
using System.Windows.Controls;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbM.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask7Class myTask7Class = new MyTask7Class(Convert.ToDouble(TbM.Text), Convert.ToDouble(TbM.Text));

                MessageBox.Show($"N = {myTask7Class.N()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbM.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
