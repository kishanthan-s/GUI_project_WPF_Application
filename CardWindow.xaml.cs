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
                holder.Focus();
                 }

            private string UsN = Global.UserName;
            /*    public CardWindow(string UN) : this()
                {
                    UsN = UN;
                }
            */
            private void Button_Click(object sender, RoutedEventArgs e)
            {

            this.Close();

        }
         
        public void addbtn()
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


                        User_Name = Global.UserName,
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

                Global.PaymentMethod = "card";
                MessageBox.Show("Successfully Submited!!");

                this.Close();
            }

        }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
            addbtn();


            }

            private void month_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

            private void cbi2_Selected(object sender, RoutedEventArgs e)
            {

            }

        private void holder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                type.Focus();
            }
        }

        private void type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                no.Focus();
            }
        }
        private void no_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                month.Focus();
            }
        }

        private void month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                year.Focus();
            }

        }

        private void year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PW.Focus();
            }
        }

        private void PW_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {



                case Key.F5:
                    this.Close();
                    break;


                case Key.F9:
                    addbtn();
                    //  PaymentBtn();
                    break;


            }
        }

     

       
    }
    }