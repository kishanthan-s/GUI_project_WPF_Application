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
    /// Interaction logic for Address.xaml
    /// </summary>
    public partial class Address : Window
    {
        public Address()
        {
            InitializeComponent();
        }
       

        public Address(string CN, string EM, string DN, string AN, string SN, string LM, string PR, string PL, string CT, string ID) : this()
        {

           // User_name = UsN, couldn't add
            Customer_name.Text = CN;
            Email.Text = EM;
            DoorNo.Text = DN;
            Apartment_Name.Text = AN;
            Street_Name.Text = SN;
            Landmark.Text = LM;
            Province.Text = PR;
            Place.Text = PL;
            City.Text = CT;
            Customer_Id.Text = ID;


        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            if (Customer_name.Text == "")
            {
                MessageBox.Show("Complete all ");
            }


            else if (Email.Text == "")
            {
                MessageBox.Show("Complete all ");

            }

            else if (Apartment_Name.Text == "")
            {
                MessageBox.Show("Complete all ");

            }

            else if (Landmark.Text == "")
            {
                MessageBox.Show("Complete all ");

            }
            else if (City.Text == "")
            {
                MessageBox.Show("Complete all ");

            }


            else
            {
                using (DatabaseReposi repository = new DatabaseReposi())
                {
                    Delivery1 delivery = new Delivery1()
                    {

                        Customer_Name = Customer_name.Text,
                        Customer_ID = Customer_Id.Text,
                        Email = Email.Text,
                        Door_No = DoorNo.Text,
                        Apartment_Name = Apartment_Name.Text,
                        Street_name = Street_Name.Text,
                        Landmark = Landmark.Text,
                        City = City.Text,
                        Province = Province.Text,
                        Place = Place.Text,





                    };
                    repository.deliveries_set.Add(delivery);
                    repository.SaveChanges();

                    this.Close();

                }


            }



        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FoodWindow food = new FoodWindow();
            food.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Landmark_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Province_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}




