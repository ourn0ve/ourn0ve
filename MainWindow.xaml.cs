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
        private double _firstNumber = 0;
        private double _secondNumber = 0;
        private string _operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        // Обработчик для кнопок с цифрами
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                Display.Text += button.Content.ToString();
            }
        }

        // Обработчик для кнопок с операциями
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                _firstNumber = double.Parse(Display.Text);
                _operation = button.Content.ToString();
                Display.Text = "";
            }
        }

        // Обработчик для кнопки "C" (очистка)
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
        }

        // Обработчик для кнопки "=" (вычисление)
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            _secondNumber = double.Parse(Display.Text);
            double result = 0;

            switch (_operation)
            {
                case "+":
                    result = _firstNumber + _secondNumber;
                    break;
                case "-":
                    result = _firstNumber - _secondNumber;
                    break;
                case "*":
                    result = _firstNumber * _secondNumber;
                    break;
                case "/":
                    if (_secondNumber != 0)
                        result = _firstNumber / _secondNumber;
                    else
                        Display.Text = "Error: Division by zero";
                    break;
            }

            if (_operation != "/" || _secondNumber != 0)
            {
                Display.Text = result.ToString();
            }
        }
    }
}
