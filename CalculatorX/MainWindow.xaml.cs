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

namespace CalculatorX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        double _numberRow1 = 0;
        double _numberRow2 = 0;
        
        double _answer = 0;

        string[] _numbers;

        public string operation;


        public MainWindow()
        {
            InitializeComponent();

        }

        // Writing numbers
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (e.Source is Button button)
            {
                MyTextBlock.Text += button.Content;

            }

        }

        // Setting operation
        private void ButtonOp_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MyTextBlock.Text += button.Content;

                operation += button.Content;
            }

        }

        // Counting the result
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            
            _numbers = MyTextBlock.Text.Split(operation);

                _numberRow1 = Convert.ToDouble(_numbers[0]);
                _numberRow2 = Convert.ToDouble(_numbers[1]);

            if (MyTextBlock.Text.Contains("+"))
            {
                _answer = _numberRow1 + _numberRow2;

            }
            else if (MyTextBlock.Text.Contains("-"))
            {
                _answer = _numberRow1 - _numberRow2;

            }
            else if (MyTextBlock.Text.Contains("/"))
            {
                _answer = _numberRow1 / _numberRow2;
            }
            else if (MyTextBlock.Text.Contains("x"))
            {
                _answer = _numberRow1 * _numberRow2;
            }

            MyTextBlock.Text = _answer.ToString();

            operation = "";
        }

        // Clear the text block
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {

            MyTextBlock.Text = String.Empty;

        }
    }
}
