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
            Customer_name.Focus(); 
        }

        private string UsN = Convert.ToString(Global.CustomerID);
        /* public Address(string UN) : this()
         {
             Customer_name.Text = UN;

         }
        */
        public Address(string CN, string EM, string DN, string AN, string SN, string LM, string PR, string PL, string CT, string ID) : this()
        {


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

        public void addbtn()
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
                DatabaseReposi repository = new DatabaseReposi();

                if (repository.deliveries_set.Where((a => (a.User_name == UsN) && (a.Place == Global.addres))).FirstOrDefault() != null)
                {
                    update();

                }
                else
                {
                    add();
                }

                /*  using (DatabaseReposi repository = new DatabaseReposi())
                   {
                       Delivery1 delivery = new Delivery1()
                       {

                           User_name = Global.UserName,
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
                       repository.SaveChanges();*/
                Global.addres = Place.Text;
                Cart cart = new Cart();
                cart.Show();

                this.Close();




            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            addbtn();



        }
        public void update()
        {
            DatabaseReposi repository = new DatabaseReposi();
            var PatUpdate = repository.deliveries_set.Where((a => (a.User_name == UsN) && (a.Place == Global.addres))).FirstOrDefault();///passes patient id


            PatUpdate.User_name = UsN;
            PatUpdate.Customer_Name = Customer_name.Text;
            PatUpdate.Customer_ID = Customer_Id.Text;
            PatUpdate.Email = Email.Text;
            PatUpdate.Door_No = DoorNo.Text;
            PatUpdate.Apartment_Name = Apartment_Name.Text;
            PatUpdate.Street_name = Street_Name.Text;
            PatUpdate.Landmark = Landmark.Text;
            PatUpdate.City = City.Text;
            PatUpdate.Province = Province.Text;
            PatUpdate.Place = Place.Text;

            repository.SaveChanges();
            Global.addressMethod = Place.Text;
            MessageBox.Show("Successfully Updated!!");

        }

        public void add()
        {
            DatabaseReposi repository = new DatabaseReposi();

            Delivery1 delivery = new Delivery1()
            {

                User_name = UsN,
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
            Global.addressMethod = Place.Text;

            MessageBox.Show("Successfully Added!!");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FoodWindow food = new FoodWindow();
            food.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();

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
            Cart cart = new Cart();
            cart.Show();

            this.Close();
        }

        private void Customer_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Customer_Id.Focus();
            }
        }

        private void Customer_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Email.Focus();
            }
        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DoorNo.Focus();
            }
        }

        private void DoorNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Apartment_Name.Focus();
            }
        }

        private void Apartment_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Street_Name.Focus();
            }
        }

        private void Street_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Landmark.Focus();
            }
        }

        private void Landmark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                City.Focus();
            }

        }

        private void City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Province.Focus();
            }

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


