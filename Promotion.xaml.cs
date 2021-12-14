using Homepage;
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
            CheckID();
          //  load();
        }
///load data
        public void load()
        {

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.promotion.Where(b => (b.Customer_ID ==Global.CustomerID) && (b.BuyScussess == 1)).ToList();
            newCart.ItemsSource = cartListF1;
        }
        // using (DatabaseReposi repositio = new DatabaseReposi())
        //promo promotions = new promo()
        public void Functocaltotal ( int ItemPrize, string quantity )
        {
            int totalPrice;
            int item = ItemPrize;
            int  quantity1 = int.Parse(quantity);
            totalPrice = item * quantity1;
            Global.PromoTotalBill += totalPrice;
            lbltotal.Content ="promotion bill="+ Convert.ToString(Global.PromoTotalBill);

        }

        public void CheckID()
        {
            DatabaseReposi repository1 = new DatabaseReposi();
            var CheckIDCustomer = repository1.buyer.Where(b => b.EmailID == Global.Email).FirstOrDefault();
            Global.CustomerID = CheckIDCustomer.CustomerID;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Visibility == Visibility.Collapsed)
            {
                button2.Visibility = Visibility.Visible;
            }

            if (ta.Visibility == Visibility.Collapsed)
            {
                ta.Visibility = Visibility.Visible;
            }
            if (cmdUp.Visibility == Visibility.Collapsed)
            {
                cmdUp.Visibility = Visibility.Visible;
            }
            if (cmdDown.Visibility == Visibility.Collapsed)
            {
                cmdDown.Visibility = Visibility.Visible;
            }
            if (oa.Visibility == Visibility.Collapsed)
            {
                oa.Visibility = Visibility.Visible;
            }
        }



       /* private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            button2.Visibility = Visibility.Collapsed;
            cmdUp.Visibility = Visibility.Collapsed;
            cmdDown.Visibility = Visibility.Collapsed;
            ta.Visibility = Visibility.Collapsed;
            oa.Visibility = Visibility.Collapsed;
            if (button1.Visibility == Visibility.Collapsed)
            {
                button1.Visibility = Visibility.Visible;
            }
            ta.Text = numValue.ToString();

        }*/

        private void CmdUp_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(ta.Text);
            if (input > 0)
            {
                int inout = input - 1;
                ta.Text = inout.ToString();

            }
        }

        private void CmdDown_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(ta.Text);
            int inout = input + 1;
            ta.Text = inout.ToString();
        }
        private int numValue = 0;


        public void NumberUpDown()
        {
            InitializeComponent();
            ta.Text = numValue.ToString();




        }

        private void oa_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {

                promo promotions = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D1",
                    Item_Name = "Chochalate offers ",
                    Item_Prize = 400,
                    Quantity = int.Parse(ta.Text),
                    Total_prize = int.Parse(ta.Text) * 400,
                    BuyScussess = 1,
                   
                };
                repository.promotion.Add(promotions);
                repository.SaveChanges();


                /////sending to global variable
                /*int totalPrice,ItemPrize,quantity;
                ItemPrize = 400;
                quantity = int.Parse(ta.Text);
                totalPrice = ItemPrize * quantity;
                Global.PromoTotalBill += totalPrice;*/
               Functocaltotal( 400, ta.Text);


                /////


                button2.Visibility = Visibility.Collapsed;
                cmdUp.Visibility = Visibility.Collapsed;
                cmdDown.Visibility = Visibility.Collapsed;
                ta.Visibility = Visibility.Collapsed;
                oa.Visibility = Visibility.Collapsed;
                if (button1.Visibility == Visibility.Collapsed)
                {
                    button1.Visibility = Visibility.Visible;
                }
                ta.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF1 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) &&(b.BuyScussess==1)).ToList();
                newCart.ItemsSource = ListF1;




            }








        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //-----------------promotion 2-------------------------------------------------------
        private void button1A_Click(object sender, RoutedEventArgs e)
        {
            if (button2A.Visibility == Visibility.Collapsed)
            {
                button2A.Visibility = Visibility.Visible;
            }

            if (taA.Visibility == Visibility.Collapsed)
            {
                taA.Visibility = Visibility.Visible;
            }
            if (cmdUpA.Visibility == Visibility.Collapsed)
            {
                cmdUpA.Visibility = Visibility.Visible;
            }
            if (cmdDownA.Visibility == Visibility.Collapsed)
            {
                cmdDownA.Visibility = Visibility.Visible;
            }
            if (oaA.Visibility == Visibility.Collapsed)
            {
                oaA.Visibility = Visibility.Visible;
            }
        }

        private void button2A_Click(object sender, RoutedEventArgs e)
        {
            button2A.Visibility = Visibility.Collapsed;
            cmdUpA.Visibility = Visibility.Collapsed;
            cmdDownA.Visibility = Visibility.Collapsed;
            taA.Visibility = Visibility.Collapsed;
            oaA.Visibility = Visibility.Collapsed;
            if (button1A.Visibility == Visibility.Collapsed)
            {
                button1A.Visibility = Visibility.Visible;
            }
            taA.Text = numValue.ToString();
        }
        private void cmdDownA_Click(object sender, RoutedEventArgs e)
        {
            int inputA = Convert.ToInt32(taA.Text);
            int inoutA = inputA + 1;
            taA.Text = inoutA.ToString();
        }

        private void cmdUpA_Click(object sender, RoutedEventArgs e)
        {
            int inputA = Convert.ToInt32(taA.Text);
            if (inputA > 0)
            {
                int inoutA = inputA - 1;
                taA.Text = inoutA.ToString();

            }
        }

        private void oaA_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                promo promotion = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D2",
                    Item_Name = "Cocacola offer ",
                    Item_Prize = 500,
                    Quantity = int.Parse(taA.Text),
                    Total_prize = int.Parse(taA.Text) * 500,
                    BuyScussess = 1,


                };
                repository.promotion.Add(promotion);
                repository.SaveChanges();

                /////sending to global variable
               /* int totalPrice, ItemPrize, quantity;
                ItemPrize = 500;
                quantity = int.Parse(taA.Text);
                totalPrice = ItemPrize * quantity;
                Global.PromoTotalBill += totalPrice;*/
                Functocaltotal(500, taA.Text);



                button2A.Visibility = Visibility.Collapsed;
                cmdUpA.Visibility = Visibility.Collapsed;
                cmdDownA.Visibility = Visibility.Collapsed;
                taA.Visibility = Visibility.Collapsed;
                oaA.Visibility = Visibility.Collapsed;
                if (button1A.Visibility == Visibility.Collapsed)
                {
                    button1A.Visibility = Visibility.Visible;
                }
                taA.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF2 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) && (b.BuyScussess == 1)).ToList();
                newCart.ItemsSource = ListF2;




            }

        }



        //---------------------------promotion 3----------------------------------


        private void button1B_Click(object sender, RoutedEventArgs e)
        {
            if (button2B.Visibility == Visibility.Collapsed)
            {
                button2B.Visibility = Visibility.Visible;
            }

            if (taB.Visibility == Visibility.Collapsed)
            {
                taB.Visibility = Visibility.Visible;
            }
            if (cmdUpB.Visibility == Visibility.Collapsed)
            {
                cmdUpB.Visibility = Visibility.Visible;
            }
            if (cmdDownB.Visibility == Visibility.Collapsed)
            {
                cmdDownB.Visibility = Visibility.Visible;
            }
            if (oaB.Visibility == Visibility.Collapsed)
            {
                oaB.Visibility = Visibility.Visible;
            }

        }

        private void button2B_Click(object sender, RoutedEventArgs e)
        {

            button2B.Visibility = Visibility.Collapsed;
            cmdUpB.Visibility = Visibility.Collapsed;
            cmdDownB.Visibility = Visibility.Collapsed;
            taB.Visibility = Visibility.Collapsed;
            oaB.Visibility = Visibility.Collapsed;
            if (button1B.Visibility == Visibility.Collapsed)
            {
                button1B.Visibility = Visibility.Visible;
            }
            taB.Text = numValue.ToString();

        }


        private void cmdDownB_Click(object sender, RoutedEventArgs e)
        {
            int inputB = Convert.ToInt32(taB.Text);
            int inoutB = inputB + 1;
            taB.Text = inoutB.ToString();
        }

        private void cmdUpB_Click(object sender, RoutedEventArgs e)
        {
            int inputB = Convert.ToInt32(taB.Text);
            if (inputB > 0)
            {
                int inoutB = inputB - 1;
                taB.Text = inoutB.ToString();

            }
        }


        private void oaB_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                promo promotion = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D3",
                    Item_Name = "Pizza offer",
                    Item_Prize = 600,
                    Quantity = int.Parse(taB.Text),
                    Total_prize = int.Parse(taB.Text) * 600,
                    BuyScussess = 1,


                };
                repository.promotion.Add(promotion);
                repository.SaveChanges();
                /////sending to global variable
               /* int totalPrice, ItemPrize, quantity;
                ItemPrize = 600;
                quantity = int.Parse(taB.Text);
                totalPrice = ItemPrize * quantity;
                Global.PromoTotalBill += totalPrice;*/
               Functocaltotal(600, taB.Text);



                button2B.Visibility = Visibility.Collapsed;
                cmdUpB.Visibility = Visibility.Collapsed;
                cmdDownB.Visibility = Visibility.Collapsed;
                taB.Visibility = Visibility.Collapsed;
                oaB.Visibility = Visibility.Collapsed;
                if (button1B.Visibility == Visibility.Collapsed)
                {
                    button1B.Visibility = Visibility.Visible;
                }
                taB.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF3 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) && (b.BuyScussess == 1)).ToList();
                newCart.ItemsSource =ListF3;




            }

        }

        //--------------------row 2 promotion 1--------------------------

        private void button1R_Click(object sender, RoutedEventArgs e)
        {
            if (button2R.Visibility == Visibility.Collapsed)
            {
                button2R.Visibility = Visibility.Visible;
            }

            if (taR.Visibility == Visibility.Collapsed)
            {
                taR.Visibility = Visibility.Visible;
            }
            if (cmdUpR.Visibility == Visibility.Collapsed)
            {
                cmdUpR.Visibility = Visibility.Visible;
            }
            if (cmdDownR.Visibility == Visibility.Collapsed)
            {
                cmdDownR.Visibility = Visibility.Visible;
            }
            if (oaR.Visibility == Visibility.Collapsed)
            {
                oaR.Visibility = Visibility.Visible;
            }

        }

        private void button2R_Click(object sender, RoutedEventArgs e)
        {
            button2R.Visibility = Visibility.Collapsed;
            cmdUpR.Visibility = Visibility.Collapsed;
            cmdDownR.Visibility = Visibility.Collapsed;
            taR.Visibility = Visibility.Collapsed;
            oaR.Visibility = Visibility.Collapsed;
            if (button1R.Visibility == Visibility.Collapsed)
            {
                button1R.Visibility = Visibility.Visible;
            }
            taR.Text = numValue.ToString();

        }

        private void cmdUpR_Click(object sender, RoutedEventArgs e)
        {
            int inputR = Convert.ToInt32(taR.Text);
            if (inputR > 0)
            {
                int inoutR = inputR - 1;
                taR.Text = inoutR.ToString();

            }
        }

        private void cmdDownR_Click(object sender, RoutedEventArgs e)
        {
            int inputR = Convert.ToInt32(taR.Text);
            int inoutR = inputR + 1;
            taR.Text = inoutR.ToString();

        }


        private void oaR_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                promo promotion = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D4",
                    Item_Name = "Burgur offer",
                    Item_Prize = 800,
                    Quantity = int.Parse(taR.Text),
                    Total_prize = int.Parse(taR.Text) * 800,
                    BuyScussess = 1,


                };
                repository.promotion.Add(promotion);
                repository.SaveChanges();
                /////sending to global variable
               /* int totalPrice, ItemPrize, quantity;
                ItemPrize = 800;
                quantity = int.Parse(taR.Text);
                totalPrice = ItemPrize * quantity;
                Global.PromoTotalBill += totalPrice;*/
                Functocaltotal(800, taR.Text);



                button2R.Visibility = Visibility.Collapsed;
                cmdUpR.Visibility = Visibility.Collapsed;
                cmdDownR.Visibility = Visibility.Collapsed;
                taR.Visibility = Visibility.Collapsed;
                oaR.Visibility = Visibility.Collapsed;
                if (button1R.Visibility == Visibility.Collapsed)
                {
                    button1R.Visibility = Visibility.Visible;
                }
                taR.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF4 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) && (b.BuyScussess == 1)).ToList();
                newCart.ItemsSource = ListF4;




            }

        }






        //-------------row 2 promotion 2----------------------------------

        private void button1AR_Click(object sender, RoutedEventArgs e)
        {
            if (button2AR.Visibility == Visibility.Collapsed)
            {
                button2AR.Visibility = Visibility.Visible;
            }

            if (taAR.Visibility == Visibility.Collapsed)
            {
                taAR.Visibility = Visibility.Visible;
            }
            if (cmdUpAR.Visibility == Visibility.Collapsed)
            {
                cmdUpAR.Visibility = Visibility.Visible;
            }
            if (cmdDownAR.Visibility == Visibility.Collapsed)
            {
                cmdDownAR.Visibility = Visibility.Visible;
            }
            if (oaAR.Visibility == Visibility.Collapsed)
            {
                oaAR.Visibility = Visibility.Visible;
            }
        }

        private void button2AR_Click(object sender, RoutedEventArgs e)
        {
            button2AR.Visibility = Visibility.Collapsed;
            cmdUpAR.Visibility = Visibility.Collapsed;
            cmdDownAR.Visibility = Visibility.Collapsed;
            taAR.Visibility = Visibility.Collapsed;
            oaAR.Visibility = Visibility.Collapsed;
            if (button1AR.Visibility == Visibility.Collapsed)
            {
                button1AR.Visibility = Visibility.Visible;
            }
            taAR.Text = numValue.ToString();
        }
        private void cmdDownAR_Click(object sender, RoutedEventArgs e)
        {
            int inputAR = Convert.ToInt32(taAR.Text);
            int inoutAR = inputAR + 1;
            taAR.Text = inoutAR.ToString();
        }

        private void cmdUpAR_Click(object sender, RoutedEventArgs e)
        {
            int inputAR = Convert.ToInt32(taAR.Text);
            if (inputAR > 0)
            {
                int inoutAR = inputAR - 1;
                taAR.Text = inoutAR.ToString();

            }
        }

        private void oaAR_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                promo promotion = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D5",
                    Item_Name = " Burgur offer double",
                    Item_Prize = 1500,
                    Quantity = int.Parse(taAR.Text),
                    Total_prize = int.Parse(taAR.Text) * 1500,
                    BuyScussess = 1,


                };
                repository.promotion.Add(promotion);
                repository.SaveChanges();

                /////sending to global variable
               /* int totalPrice, ItemPrize, quantity;
                ItemPrize = 1500;
                quantity = int.Parse(taAR.Text);
                totalPrice = ItemPrize * quantity;
                Global.PromoTotalBill += totalPrice;*/
                Functocaltotal(1500, taAR.Text);



                button2AR.Visibility = Visibility.Collapsed;
                cmdUpAR.Visibility = Visibility.Collapsed;
                cmdDownAR.Visibility = Visibility.Collapsed;
                taAR.Visibility = Visibility.Collapsed;
                oaAR.Visibility = Visibility.Collapsed;
                if (button1AR.Visibility == Visibility.Collapsed)
                {
                    button1AR.Visibility = Visibility.Visible;
                }
                taAR.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF5 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) && (b.BuyScussess == 1)).ToList();
                newCart.ItemsSource =ListF5;




            }

        }

        //-------------------row 2 promotion 3------------------
        private void button1BR_Click(object sender, RoutedEventArgs e)
        {
            if (button2BR.Visibility == Visibility.Collapsed)
            {
                button2BR.Visibility = Visibility.Visible;
            }

            if (taBR.Visibility == Visibility.Collapsed)
            {
                taBR.Visibility = Visibility.Visible;
            }
            if (cmdUpBR.Visibility == Visibility.Collapsed)
            {
                cmdUpBR.Visibility = Visibility.Visible;
            }
            if (cmdDownBR.Visibility == Visibility.Collapsed)
            {
                cmdDownBR.Visibility = Visibility.Visible;
            }
            if (oaBR.Visibility == Visibility.Collapsed)
            {
                oaBR.Visibility = Visibility.Visible;
            }

        }

        private void button2BR_Click(object sender, RoutedEventArgs e)
        {

            button2BR.Visibility = Visibility.Collapsed;
            cmdUpBR.Visibility = Visibility.Collapsed;
            cmdDownBR.Visibility = Visibility.Collapsed;
            taBR.Visibility = Visibility.Collapsed;
            oaBR.Visibility = Visibility.Collapsed;
            if (button1BR.Visibility == Visibility.Collapsed)
            {
                button1BR.Visibility = Visibility.Visible;
            }
            taBR.Text = numValue.ToString();

        }


        private void cmdDownBR_Click(object sender, RoutedEventArgs e)
        {
            int inputBR = Convert.ToInt32(taBR.Text);
            int inoutBR = inputBR + 1;
            taBR.Text = inoutBR.ToString();
        }

        private void cmdUpBR_Click(object sender, RoutedEventArgs e)
        {
            int inputBR = Convert.ToInt32(taBR.Text);
            if (inputBR > 0)
            {
                int inoutBR = inputBR - 1;
                taBR.Text = inoutBR.ToString();

            }
        }


        private void oaBR_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                promo promotion = new promo()
                {

                    Customer_ID = Global.CustomerID,
                    Item = "1D6",
                    Item_Name = "Cake offer",
                    Item_Prize = 2500,
                    Quantity = int.Parse(taBR.Text),
                    Total_prize = int.Parse(taBR.Text) * 2500,
                    BuyScussess = 1,


                };
                repository.promotion.Add(promotion);
                repository.SaveChanges();
                /////sending to global variable
                /*  int totalPrice, ItemPrize, quantity;
                  ItemPrize = 2500;
                  quantity = int.Parse(taBR.Text);
                  totalPrice = ItemPrize * quantity;
                  Global.PromoTotalBill += totalPrice;*/
                Functocaltotal(1500, taR.Text); 




                 button2BR.Visibility = Visibility.Collapsed;
                cmdUpBR.Visibility = Visibility.Collapsed;
                cmdDownBR.Visibility = Visibility.Collapsed;
                taBR.Visibility = Visibility.Collapsed;
                oaBR.Visibility = Visibility.Collapsed;
                if (button1BR.Visibility == Visibility.Collapsed)
                {
                    button1BR.Visibility = Visibility.Visible;
                }
                taBR.Text = numValue.ToString();

                DatabaseReposi repository1 = new DatabaseReposi();
                var ListF6 = repository1.promotion.Where(b => (b.Customer_ID == Global.CustomerID) && (b.BuyScussess == 1)).ToList();
                newCart.ItemsSource = ListF6;




            }

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FoodWindow foodWindow = new FoodWindow();
            foodWindow.Show();
            Close();
            /*cus_feedback cus_win = new cus_feedback();
            cus_win.Show();
            Close();*/
        }

        private void newCart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Main_win = new MainWindow();
            Main_win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            FoodWindow Main_win = new FoodWindow();
            Main_win.Show();
        }
    }
}
