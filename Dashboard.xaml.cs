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
using System.Windows.Shapes;

namespace Airlines_App
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_adminLogin_Click(object sender, RoutedEventArgs e)
        {
            //Admin admin = new Admin();
            //this.Visibility = Visibility.Collapsed;
            //admin.Show();
            MessageBox.Show("Admin Page");
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            FlightList flightList = new FlightList();
            this.Visibility = Visibility.Collapsed;
            flightList.Show();
        }
    }
}
