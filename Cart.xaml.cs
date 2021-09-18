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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {


        public Cart()
        {
            InitializeComponent();


            add();

            using (DatabaseReposi repository = new DatabaseReposi())
            {




                var cartList = repository.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
                CartGrid.ItemsSource = cartList;

            }
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                var cartList2 = repository.deliveries_set.ToList();
                CartGrid2.ItemsSource = cartList2;

            }
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                var cartList3 = repository.class1s_set.ToList();
                CartGrid3.ItemsSource = cartList3;

            }



            using (DatabaseReposi repository = new DatabaseReposi())
            {
                int v = 0, x = CartGrid3.Items.Count;
                for (int r = 1; r < x; r++)
                {


                    var cartList1 = repository.class1s_set.Find(r);
                    if (cartList1.Customer_Name == UsN && cartList1.Buy_Scussess == 0)

                    {

                        v = v + cartList1.Total_prize;

                    };


                }
                name.Text = v.ToString();

            }


        }

        private string pr;
        private int xr = 0, pm = -0;
        private string UsN = Global.UserName;


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private string CuN, Cml;

        public void add()
        {
            if (Global.addres == "Home")
            {
                RH.IsChecked = true;
            }
            else if (Global.addres == "Work")
            {
                RW.IsChecked = true;
            }
            else if (Global.addres == "Other")
            {
                RO.IsChecked = true;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            int t = CartGrid.Items.Count;
            t = t - 1;
            if (t != 0)
            {
                if (xr != 0)
                {
                    if (pm != 0)
                    {


                        using (DatabaseReposi repository = new DatabaseReposi())
                        {
                            var cartList2 = repository.deliveries_set.ToList();
                            CartGrid2.ItemsSource = cartList2;

                        }



                        int x = CartGrid2.Items.Count;


                        if (xr == 1)
                        {
                            for (int r = 1; r < x; r++)
                            {


                                DatabaseReposi repository = new DatabaseReposi();

                                var cartList = repository.deliveries_set.Find(r);
                                if (cartList.User_name == UsN && cartList.Place == "Home")
                                {

                                    CuN = cartList.Customer_Name;
                                    Cml = cartList.Email;

                                    pr = cartList.Province;

                                    Global.province = "pr";
                                    /* FinalWindow final = new FinalWindow(pr);
                                     final.Show();*/
                                }
                            }
                        }

                        else if (xr == 2)
                        {
                            for (int r = 1; r < x; r++)
                            {


                                DatabaseReposi repository = new DatabaseReposi();

                                var cartList = repository.deliveries_set.Find(r);
                                if (cartList.User_name == UsN && cartList.Place == "Work")
                                {


                                    CuN = cartList.Customer_Name;
                                    Cml = cartList.Email;


                                    pr = cartList.Province;
                                    Global.province = "pr";
                                    /* FinalWindow final = new FinalWindow(pr);
                                     final.Show();*/
                                }
                            }
                        }



                        else if (xr == 3)
                        {
                            for (int r = 1; r < x; r++)
                            {


                                DatabaseReposi repository = new DatabaseReposi();

                                var cartList = repository.deliveries_set.Find(r);
                                if (cartList.User_name == UsN && cartList.Place == "Other")
                                {

                                    CuN = cartList.Customer_Name;
                                    Cml = cartList.Email;

                                    pr = cartList.Province;
                                    Global.province = "pr";
                                    /*
                                    FinalWindow final = new FinalWindow(pr);
                                    final.Show();*/
                                }
                            }
                        }

                        using (DatabaseReposi repository = new DatabaseReposi())
                        {
                            string Pm, AmP;

                            if (pm == 1)
                            {

                                Pm = "card";

                            }
                            else
                            {
                                Pm = "Cash on Delivery";
                            }
                            AmP = name.Text.ToString();

                            Global.province = "pr";
                            /*
                            FinalWindow final = new FinalWindow(pr);
                            final.Show();*/

                            Success success1 = new Success(CuN, Pm, AmP, Cml);
                            success1.Show();
                            this.Close();


                        }





                        using (DatabaseReposi repository = new DatabaseReposi())
                        {
                            int y = CartGrid3.Items.Count;
                            DatabaseReposi repository1 = new DatabaseReposi();
                            for (int r = 1; r < y; r++)
                            {
                                var cartList4 = repository1.class1s_set.Find(r);
                                cartList4.Buy_Scussess = 1;
                                repository1.SaveChanges();

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Set the Payment Method!");

                    }

                }
                else
                {
                    MessageBox.Show("Please Set the Delivery Address!");

                }

            }
            else
            {
                MessageBox.Show("Your Cart is Empty!");
            }



            /*



             */
        }



        private void HN_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            address.Show();


            if (hN.Visibility == Visibility.Visible)
            {
                hN.Visibility = Visibility.Hidden;
            }

        }

        private void WN_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            address.Show();
            this.Close();
            if (wN.Visibility == Visibility.Visible)
            {
                wN.Visibility = Visibility.Hidden;
            }

        }

        private void ON_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            address.Show();
            if (oN.Visibility == Visibility.Visible)
            {
                oN.Visibility = Visibility.Hidden;
            }
        }

        private void HD_Click(object sender, RoutedEventArgs e)
        {


            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Home")
                {
                    cartList.User_name = "";
                    cartList.Customer_Name = "";
                    cartList.Customer_ID = "";
                    cartList.Email = "";
                    cartList.Door_No = "";
                    cartList.Apartment_Name = "";
                    cartList.Street_name = "";
                    cartList.Landmark = "";
                    cartList.City = "";
                    cartList.Province = "";
                    cartList.Place = "";

                    repository.SaveChanges();

                }
            }
            if (hD.Visibility == Visibility.Visible)
            {
                hD.Visibility = Visibility.Hidden;
            }

            if (hE.Visibility == Visibility.Visible)
            {
                hE.Visibility = Visibility.Hidden;
            }

            if (hN.Visibility == Visibility.Hidden)
            {
                hN.Visibility = Visibility.Visible;
            }

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartList2 = repository1.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList2;




            /*      using (DatabaseReposi repository = new DatabaseReposi())
                  {
                      var cartList3 = repository.deliveries.ToList();
                      CartGrid2.ItemsSource = cartList3;

                  }
            */
        }

        private string CN, EM, DN, AN, SN, LM, PR, PL, CT, ID;

        private void HE_Click(object sender, RoutedEventArgs e)
        {


            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Home")
                {

                    CN = cartList.User_name;
                    EM = cartList.Email;
                    DN = cartList.Door_No;
                    AN = cartList.Apartment_Name;
                    SN = cartList.Street_name;
                    LM = cartList.Landmark;
                    PR = cartList.Province;
                    PL = cartList.Place;
                    CT = cartList.City;
                    ID = cartList.Customer_ID;

                    Address address = new Address(CN, EM, DN, AN, SN, LM, PR, PL, CT, ID);
                    address.Show();

                    cartList.User_name = "";
                    cartList.Place = "";
                    repository.SaveChanges();
                }
            }



        }

        private void WD_Click(object sender, RoutedEventArgs e)
        {


            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Work")
                {
                    cartList.User_name = "";
                    cartList.Customer_Name = "";
                    cartList.Customer_ID = "";
                    cartList.Email = "";
                    cartList.Door_No = "";
                    cartList.Apartment_Name = "";
                    cartList.Street_name = "";
                    cartList.Landmark = "";
                    cartList.City = "";
                    cartList.Province = "";
                    cartList.Place = "";

                    repository.SaveChanges();

                    cartList.User_name = "";
                    cartList.Place = "";
                    repository.SaveChanges();
                }

            }
            if (wD.Visibility == Visibility.Visible)
            {
                wD.Visibility = Visibility.Hidden;
            }

            if (wE.Visibility == Visibility.Visible)
            {
                wE.Visibility = Visibility.Hidden;
            }

            if (wN.Visibility == Visibility.Hidden)
            {
                wN.Visibility = Visibility.Visible;
            }

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartList2 = repository1.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList2;

        }

        private void WE_Click(object sender, RoutedEventArgs e)
        {

            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Work")
                {


                    CN = cartList.User_name;
                    EM = cartList.Email;
                    DN = cartList.Door_No;
                    AN = cartList.Apartment_Name;
                    SN = cartList.Street_name;
                    LM = cartList.Landmark;
                    PR = cartList.Province;
                    PL = cartList.Place;
                    CT = cartList.City;
                    ID = cartList.Customer_ID;
                    Address address = new Address(CN, EM, DN, AN, SN, LM, PR, PL, CT, ID);


                    address.Show();
                    this.Close();

                }
            }
        }

        private void OD_Click(object sender, RoutedEventArgs e)
        {


            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Other")
                {
                    cartList.User_name = "";
                    cartList.Customer_Name = "";
                    cartList.Customer_ID = "";
                    cartList.Email = "";
                    cartList.Door_No = "";
                    cartList.Apartment_Name = "";
                    cartList.Street_name = "";
                    cartList.Landmark = "";
                    cartList.City = "";
                    cartList.Province = "";
                    cartList.Place = "";

                    repository.SaveChanges();

                    cartList.User_name = "";
                    cartList.Place = "";
                    repository.SaveChanges();
                }


            }
            if (oD.Visibility == Visibility.Visible)
            {
                oD.Visibility = Visibility.Hidden;
            }

            if (oE.Visibility == Visibility.Visible)
            {
                oE.Visibility = Visibility.Hidden;
            }

            if (oN.Visibility == Visibility.Hidden)
            {
                oN.Visibility = Visibility.Visible;
            }
            DatabaseReposi repository1 = new DatabaseReposi();
            var cartList2 = repository1.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList2;
        }

        private void OE_Click(object sender, RoutedEventArgs e)
        {

            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Other")
                {


                    CN = cartList.User_name;
                    EM = cartList.Email;
                    DN = cartList.Door_No;
                    AN = cartList.Apartment_Name;
                    SN = cartList.Street_name;
                    LM = cartList.Landmark;
                    PR = cartList.Province;
                    PL = cartList.Place;
                    CT = cartList.City;
                    ID = cartList.Customer_ID;
                    Address address = new Address(CN, EM, DN, AN, SN, LM, PR, PL, CT, ID);


                    address.Show();

                }
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void CartGrid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void RH_Checked(object sender, RoutedEventArgs e)
        {
            Global.addres = "Home";
            xr = 1;



            wN.Visibility = Visibility.Hidden;
            wD.Visibility = Visibility.Hidden;
            wE.Visibility = Visibility.Hidden;

            oN.Visibility = Visibility.Hidden;
            oD.Visibility = Visibility.Hidden;
            oE.Visibility = Visibility.Hidden;


            DatabaseReposi repository1 = new DatabaseReposi();
            var cartList11 = repository1.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList11;
            int x = CartGrid2.Items.Count;
            /*  for (int r = 1; r < x; r++)
              {
                  DatabaseReposi repository = new DatabaseReposi();

                  var cartList = repository.deliveries_set.Find(r);
                  if (cartList.User_name == UsN && cartList.Place == "Home")
                  {


                      pr = cartList.Province;
                      FinalWindow final1 = new FinalWindow(pr);
                      final1.Show();


                  }
              }*/
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository11 = new DatabaseReposi();

                var cartList1 = repository11.deliveries_set.Find(r);
                if (cartList1.User_name == UsN && cartList1.Place == "Home")
                {


                    hD.Visibility = Visibility.Visible;
                    hE.Visibility = Visibility.Visible;



                }

            }
            if (hD.Visibility == Visibility.Hidden)
            {
                hN.Visibility = Visibility.Visible;
            }



        }

        private void RW_Checked(object sender, RoutedEventArgs e)
        {
            Global.addres = "Work";
            xr = 2;


            hN.Visibility = Visibility.Hidden;
            hD.Visibility = Visibility.Hidden;
            hE.Visibility = Visibility.Hidden;

            oN.Visibility = Visibility.Hidden;
            oD.Visibility = Visibility.Hidden;
            oE.Visibility = Visibility.Hidden;


            DatabaseReposi repository2 = new DatabaseReposi();
            var cartList22 = repository2.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList22;

            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository22 = new DatabaseReposi();

                var cartList2 = repository22.deliveries_set.Find(r);
                if (cartList2.User_name == UsN && cartList2.Place == "Work")
                {

                    wD.Visibility = Visibility.Visible;
                    wE.Visibility = Visibility.Visible;



                }

            }
            if (wD.Visibility == Visibility.Hidden)
            {
                wN.Visibility = Visibility.Visible;
            }

        }

        private void RO_Checked(object sender, RoutedEventArgs e)
        {
            Global.addres = "Other";
            xr = 3;


            wN.Visibility = Visibility.Hidden;
            wD.Visibility = Visibility.Hidden;
            wE.Visibility = Visibility.Hidden;

            hN.Visibility = Visibility.Hidden;
            hD.Visibility = Visibility.Hidden;
            hE.Visibility = Visibility.Hidden;



            DatabaseReposi repository3 = new DatabaseReposi();
            var cartList33 = repository3.deliveries_set.ToList();
            CartGrid2.ItemsSource = cartList33;

            int x = CartGrid2.Items.Count;
            sell.Text = x.ToString();

            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository33 = new DatabaseReposi();
                var cartList3 = repository33.deliveries_set.Find(r);
                if (cartList3.User_name == UsN && cartList3.Place == "Other")
                {

                    oD.Visibility = Visibility.Visible;
                    oE.Visibility = Visibility.Visible;



                }

            }
            if (oD.Visibility == Visibility.Hidden)
            {
                oN.Visibility = Visibility.Visible;
            }




        }



        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            pm = 1;

            if (cash.Visibility == Visibility.Visible)
            {
                cash.Visibility = Visibility.Hidden;
            }
            CardWindow card = new CardWindow();
            card.ShowDialog();


        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            pm = 2;

            if (cash.Visibility == Visibility.Hidden)
            {
                cash.Visibility = Visibility.Visible;
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

            DatabaseReposi repository = new DatabaseReposi();


            var deliveryList = repository.deliveries_set.ToList();
            DeliveryGrid.ItemsSource = deliveryList;

            Application.Current.Shutdown();

        }

        private void CartGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void CartGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void pls()
        {


        }
    }

}
