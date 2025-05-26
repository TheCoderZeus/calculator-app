using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace DarkCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Display.Text += button.Content.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = Display.Text;
                var result = new DataTable().Compute(expression, null);
                Display.Text = result.ToString();
            }
            catch
            {
                Display.Text = "Erro";
            }
        }
    }
}
