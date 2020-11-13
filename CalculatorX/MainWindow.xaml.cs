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


        double numberRow1 = 0;
        double numberRow2 = 0;
        double computation = 0;
        string operation = "";

        double click;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if(operation == "")
            {
                if (e.Source is Button button)
                {
                    MyTextBlock.Text += button.Content;
                    click = Convert.ToInt32(button.Content);
                }
                numberRow1 = (numberRow1) + click;
            }
            else
            {
                if (e.Source is Button button)
                {
                    MyTextBlock.Text += button.Content;
                    click = Convert.ToInt32(button.Content);
                }
                numberRow1 = (numberRow1) + click;
            }
            

        }

        private void ButtonOp_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MyTextBlock.Text += button.Content;
                
                if (button.Content == "+")
                {
                    computation = numberRow1 + numberRow2;
                }
                else if (button.Content == "-")
                {
                    computation = numberRow1 - numberRow2;
                }
            }
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {

            if (e.Source is Button button)
            {

                if (operation == (numberRow1 + "+" + numberRow2))
            {
                MyTextBlock.Text = (numberRow1 + numberRow2).ToString();

            }
            else if (operation == "-")
            {
                MyTextBlock.Text = (numberRow1 + numberRow2).ToString();

            }
            else if (operation == "/")
            {
                MyTextBlock.Text = (numberRow1 / numberRow2).ToString();
            }
            else if (operation == "x")
            {
                MyTextBlock.Text = (numberRow1 * numberRow2).ToString();
            }

            }
            
      
        }

        
    }
}
