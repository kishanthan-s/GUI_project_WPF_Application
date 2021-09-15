using Online_Food_Order_Software.Database;
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
    /// Interaction logic for FinalWindow.xaml
    /// </summary>
    public partial class FinalWindow : Window
    {
        public FinalWindow()
        {
            InitializeComponent();
        }

        public FinalWindow(string pr) : this()
        {


            int x = 10;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var suplier = repository.supliers_set.Find(r);
                if (suplier.Province == pr)
                {
                    SUP.Text = suplier.Name;
                    CON.Text = suplier.Contact_No;
                    VEH.Text = suplier.Vehical_No;


                }
            }

        }







        private void MediaEliment_MediaEnded(object sender, RoutedEventArgs e)
        {
            me.Position = TimeSpan.FromMilliseconds(1);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FoodWindow food = new FoodWindow();
            food.Show();
            this.Close();

        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();


            /*Next*/

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void SUP_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
