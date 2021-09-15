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
    /// Interaction logic for CardWindow.xaml
    /// </summary>
    public partial class CardWindow : Window
    {
        public CardWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (holder.Text == "")
            {
                MessageBox.Show("Complete all ");
            }


            else if (type.Text == "")
            {
                MessageBox.Show("Complete all ");

            }

            else if (no.Text == "")
            {
                MessageBox.Show("Complete all ");

            }

            else if (month.Text == "")
            {
                MessageBox.Show("Complete all ");

            }
            else if (year.Text == "")
            {
                MessageBox.Show("Complete all ");

            }
            else if (PW.Password == "")
            {
                MessageBox.Show("Complete all ");

            }

            else
            {
                using (DatabaseReposi repository1 = new DatabaseReposi())
                {

                    Payment payment = new Payment()
                    {


                        //User_Name = UsN, didnt add
                        Card_Holder_Name = holder.Text,
                        Payment_Method = "Card",
                        Card_Type = type.Text,
                        Card_Number = no.Text,
                        Expire_Month = month.Text,
                        Expire_Year = year.Text,


                    };
                    repository1.payments_set.Add(payment);
                    repository1.SaveChanges();
                }




                this.Close();
            }


        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbi2_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}

