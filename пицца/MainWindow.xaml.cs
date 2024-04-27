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

namespace пицца
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int totalPrice;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pizzasList.Items.Add("Pepproni" );
            totalPrice += 52;
            TotPrice.Text = totalPrice.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pizzasList.Items.Clear();
            totalPrice = 0;
            TotPrice.Text = totalPrice.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pizzasList.Items.Add("oxota");
            totalPrice += 30;
            TotPrice.Text = totalPrice.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pizzasList.Items.Add("chess");
            totalPrice += 40;
            TotPrice.Text = totalPrice.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            pizzasList.Items.Clear();
            totalPrice = 0;
            TotPrice .Text = totalPrice.ToString();
        }
    }
}
