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

namespace ourn0ve
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            double num1 = 10; // Пример числа 1
            double num2 = 5;  // Пример числа 2
            double result = num1 + num2;
            Display.Text = result.ToString();
        }
        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            double num1 = 10; // Пример числа 1
            double num2 = 5;  // Пример числа 2
            double result = num1 - num2;
            Display.Text = result.ToString();
        }
    }
}
