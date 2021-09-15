using Online_Food_Order_Software.Database;
using Online_Food_Order_Software.Models;
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

namespace Online_Food_Order_Software
{
    /// <summary>
    /// Interaction logic for Promotion.xaml
    /// </summary>
    public partial class Promotion : Window
    {
        public Promotion()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repositio = new DatabaseReposi())
            {
                promo promotions = new promo()
                {

                    customerID = CusID.cusid,
                    itemID = "10",
                    discount = "50",
                    itemPrice = "5000"
                };
                repositio.promotion.Add(promotions);
                repositio.SaveChanges();
                this.Close();
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            cus_feedback cus_win = new cus_feedback();
            cus_win.Show();
            Close();
        }
    }
}
