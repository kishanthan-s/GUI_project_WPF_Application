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
    /// Interaction logic for Success.xaml
    /// </summary>
    public partial class Success : Window
    {
        public Success()
        {
            InitializeComponent();


            /*

            using (DatabaseReposi repository = new DatabaseReposi())
            {
                var cartList = repository.Cart1s.Where(b => b.Customer_Name == "Kasun" && b.Buy_Scussess == 0).ToList();
                CartGrid.ItemsSource = cartList;

            }
            */
            CN.Text = Global.CustomerName;
            cuml.Text = Global.CustomerEmail; 


        }

        public Success(string CuN, string pt, string AmP, string Cml) : this()
        {


            PT.Text = pt;
            AP.Text =Convert.ToString( Global.totalBill);
          

            PD.Text = DateTime.Now.ToString("yyyy/MM/dd");




        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            FinalWindow finalWindow = new FinalWindow();
            finalWindow.Show();
            Global.province = "null";
            Global.addres = "null";




            this.Close();
        }

        private void cuml_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}