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
using PrettyHair.UI.View;

namespace PrettyHair.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOrders_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void buttonCustomers_Click(object sender, RoutedEventArgs e)
        {
            Customer costumer = new Customer();
            costumer.Show();
        }

        private void buttonItems_Click(object sender, RoutedEventArgs e)
        {
            Items items = new Items();
            items.Show();
        }
    }
}
