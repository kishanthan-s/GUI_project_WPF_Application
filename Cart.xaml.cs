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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {


        public Cart()
        {
            InitializeComponent();


            add();
            sell.Text = Convert.ToString(Global.PromoTotalBill);
            initFunc();
            total();

        }
        public void initFunc()
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {


                var cartList = repository.promotion.Where(b => b.Customer_ID == Global.CustomerID && b.BuyScussess ==1).ToList();
                CartGrid_pro.ItemsSource = cartList;

            }

            using (DatabaseReposi repository = new DatabaseReposi())
            {


                var cartList = repository.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess == 0).ToList();
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
                var cartList4 = repository.promotion.ToList();
                CartGrid4.ItemsSource = cartList4;

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
                Global.cartlBill += v;
            }
            

            using (DatabaseReposi repository = new DatabaseReposi())
            {
                int v = 0, x = CartGrid4.Items.Count;
                for (int r = 1; r < x; r++)
                {
                   

                    var cartList1 = repository.promotion.Find(r);
                  
                        if (cartList1.Customer_ID == Global.CustomerID && cartList1.BuyScussess == 1)

                        {
                           // MessageBox.Show("ok");
                            v = v + cartList1.Total_prize;
                            break;
                        };

                    


                }
                sell.Text = v.ToString();
                Global.PromoTotalBill += v;
            }










        }

        public void total()
        {
            Global.totalBill = Global.PromoTotalBill + Global.cartlBill;
            totalBill.Text = Convert.ToString(Global.totalBill);
        }

        private string pr;
        private int xr = 0, pm = -0;

        private string UsN = Convert.ToString(Global.CustomerID);

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

        public void addCompletePromo()
        {

            using (DatabaseReposi repository = new DatabaseReposi())
            {
                int y = CartGrid4.Items.Count;
                DatabaseReposi repository1 = new DatabaseReposi();
                for (int r = 1; r < y; r++)
                {
                    var cartList4 = repository1.promotion.Find(r);
                    cartList4.BuyScussess = 2;
                    repository1.SaveChanges();

                }
            }
        }

        public void setDeliveryDetails()
        {
            DatabaseReposi repository1 = new DatabaseReposi();

         if ( repository1.deliveries_set.Where(a => ((a.User_name == UsN)) && ((a.Place == Global.addressMethod))).FirstOrDefault() != null)
            {
                var detais = repository1.deliveries_set.Where(a => ((a.User_name == UsN)) && ((a.Place == Global.addressMethod))).FirstOrDefault();


                Global.CustomerEmail = detais.Email;
                Global.CustomerName = detais.Customer_Name;
                Global.CustomerProvince = detais.Province;

               
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            int t = CartGrid.Items.Count;
            t = t - 1;
            if (t != 0)
            {
                if (Global.addressMethod != null)
                {
                    if (Global.PaymentMethod != null)
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

                                    //   Global.province = "pr";
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
                                    //  Global.province = "pr";
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
                                    //   Global.province = "pr";
                                    /*
                                    FinalWindow final = new FinalWindow(pr);
                                    final.Show();*/
                                }
                            }
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

                            //  Global.province = "pr";
                            /*
                            FinalWindow final = new FinalWindow(pr);
                            final.Show();*/
                            Global.totalBill = 0;
                            Global.PromoTotalBill = 0;
                            Global.cartlBill = 0;
                            addCompletePromo();
                            setDeliveryDetails();
                            Success success1 = new Success(CuN, Pm, AmP, Cml);
                            success1.Show();
                            this.Close();


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
            this.Close();


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
            this.Close();
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
            Global.AddressEdite = "ok";

            Address address = new Address();
            address.Show();
            this.Close();



            /*

            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Home")
                {

                    CN = cartList.Customer_Name;
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
            */


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
            Global.AddressEdite = "ok";

            Address address = new Address();
            address.Show();

            this.Close();


            /*

            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Work")
                {


                    CN = cartList.Customer_Name;
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
            }*/
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
            Global.AddressEdite = "ok";

            Address address = new Address();
            address.Show();

            this.Close();
            /*
            int x = CartGrid2.Items.Count;
            for (int r = 1; r < x; r++)
            {
                DatabaseReposi repository = new DatabaseReposi();

                var cartList = repository.deliveries_set.Find(r);
                if (cartList.User_name == UsN && cartList.Place == "Other")
                {


                    CN = cartList.Customer_Name;
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
            */
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Global.DirectToHome();
            this.Close();
            /*
            DatabaseReposi repository = new DatabaseReposi();


            var deliveryList = repository.deliveries_set.ToList();
            DeliveryGrid.ItemsSource = deliveryList;

            Application.Current.Shutdown();

            */
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FoodWindow foodWindow = new FoodWindow();
            foodWindow.Show();
            this.Close();
        }

        private void CartGrid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        public void CheckHome()
        {
            allHidden();

            DatabaseReposi repository1 = new DatabaseReposi();
            if (repository1.deliveries_set.Where(a => ((a.User_name == UsN)) && ((a.Place == "Home"))).FirstOrDefault() != null)
            {
                Global.addressMethod = "Home";
                hD.Visibility = Visibility.Visible;
                hE.Visibility = Visibility.Visible;

            }
            else
            {
                hN.Visibility = Visibility.Visible;

            }
        }
        public void CheckWork()
        {
            allHidden();

            DatabaseReposi repository1 = new DatabaseReposi();
            if (repository1.deliveries_set.Where(a => ((a.User_name == UsN)) && ((a.Place == "Work"))).FirstOrDefault() != null)
            {
                Global.addressMethod = "Work";

                wD.Visibility = Visibility.Visible;
                wE.Visibility = Visibility.Visible;
            }
            else
            {
                wN.Visibility = Visibility.Visible;

            }
        }
        public void CheckOther()
        {
            allHidden();

            DatabaseReposi repository1 = new DatabaseReposi();
            if (repository1.deliveries_set.Where(a => ((a.User_name == UsN)) && ((a.Place == "Other"))).FirstOrDefault() != null)
            {
                Global.addressMethod = "Other";

                oD.Visibility = Visibility.Visible;
                oE.Visibility = Visibility.Visible;

            }
            else
            {
                oN.Visibility = Visibility.Visible;

            }
        }

        private void total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_DelPat_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure want to delelte?\nAll details related this item will be lost.", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No))
            {
                Class1 SelPat = CartGrid.SelectedItem as Class1;
                if (SelPat == null) return;
                using (DatabaseReposi QueryDel = new DatabaseReposi())
                {
                    var Pat = QueryDel.class1s_set.Find(SelPat.Cart_ID1);
                    //cancel
                    Pat.Buy_Scussess = 2;
                    QueryDel.SaveChanges();
                }

                initFunc();
                total();
                //  DelPrev();
                //  load();

            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure want to delelte?\nAll details related this item will be lost.", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No))
            {
                promo SelPat = CartGrid_pro.SelectedItem as promo;
                if (SelPat == null) return;
                using (DatabaseReposi QueryDelitem = new DatabaseReposi())
                {
                    var check = QueryDelitem.promotion.Find(SelPat.PromoId);
                    int debill = check.Total_prize;
                    Global.PromoTotalBill = Global.PromoTotalBill - debill;
                    //cancel
                    check.BuyScussess = 0;
                    QueryDelitem.SaveChanges();
                }

                initFunc();
                total();
                //  DelPrev();
                //  load();

            }
        }

        public void allHidden()
        {
            wN.Visibility = Visibility.Hidden;
            wD.Visibility = Visibility.Hidden;
            wE.Visibility = Visibility.Hidden;

            oN.Visibility = Visibility.Hidden;
            oD.Visibility = Visibility.Hidden;
            oE.Visibility = Visibility.Hidden;
        }
        private void RH_Checked(object sender, RoutedEventArgs e)
        {
            CheckHome();

            /*  Global.addres = "Home";
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
            /*    for (int r = 1; r < x; r++)
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


                */
        }

        private void RW_Checked(object sender, RoutedEventArgs e)
        {
            Global.addres = "Work";
            CheckWork();
            /*   xr = 2;


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
            */
        }

        private void RO_Checked(object sender, RoutedEventArgs e)
        {
            Global.addres = "Other";
            CheckOther();
            /*  xr = 3;


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


              */

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
                Global.PaymentMethod = "Cash on Delivery";
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
            Global.DirectToLogout();
            this.Close();


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
