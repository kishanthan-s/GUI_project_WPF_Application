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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Online_Food_Order_Software
{
    /// <summary>
    /// Interaction logic for Drink1.xaml
    public partial class Drink1 : Page
    {
        public Drink1()
        {
            InitializeComponent();




            using (DatabaseReposi repository = new DatabaseReposi())
            {

                var cartListF1 = repository.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess == 0).ToList();
                newCart.ItemsSource = cartListF1;

                DatabaseReposi repository1 = new DatabaseReposi();
                var cartListF2 = repository.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess == 1).ToList();
                CartGridF1.ItemsSource = cartListF2;

            }
        }



        private string UsN = Convert.ToString(Global.CustomerID);
        /*   public Food1(string UN) : this()
           {
               n.Text = UN;
           }


           /*********************************aaaaaaaaaaaaaaaaaaaa***********************************************/
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
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

        }

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
            tb.Text = numValue.ToString();
            tc.Text = numValue.ToString();
            td.Text = numValue.ToString();
            te.Text = numValue.ToString();



        }
        private void oa_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D1",
                    Item_Name = "Red BUll Energy ",
                    Item_Prize = 400,
                    Quantity = int.Parse(ta.Text),
                    Total_prize = int.Parse(ta.Text) * 400,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();



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
                var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess == 0).ToList();
                newCart.ItemsSource = cartListF1;


            }






        }
        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /************************************bbbbbbbbbbbbbbbbbbbbbb********************************/
        private void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {

            if (bb2.Visibility == Visibility.Collapsed)
            {
                bb2.Visibility = Visibility.Visible;
            }

            if (tb.Visibility == Visibility.Collapsed)
            {
                tb.Visibility = Visibility.Visible;
            }
            if (ub.Visibility == Visibility.Collapsed)
            {
                ub.Visibility = Visibility.Visible;
            }
            if (db.Visibility == Visibility.Collapsed)
            {
                db.Visibility = Visibility.Visible;
            }
            if (ob.Visibility == Visibility.Collapsed)
            {
                ob.Visibility = Visibility.Visible;
            }

        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {

            bb2.Visibility = Visibility.Collapsed;
            ub.Visibility = Visibility.Collapsed;
            db.Visibility = Visibility.Collapsed;
            tb.Visibility = Visibility.Collapsed;
            ob.Visibility = Visibility.Collapsed;

            if (bb1.Visibility == Visibility.Collapsed)
            {
                bb1.Visibility = Visibility.Visible;
            }
            tb.Text = numValue.ToString();
        }

        private void Ub_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tb.Text);
            if (input > 0)
            {
                int inout = input - 1;
                tb.Text = inout.ToString();
            }
        }

        private void Db_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tb.Text);
            int inout = input + 1;
            tb.Text = inout.ToString();
        }

        private void ob_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D2",
                    Item_Name = "7UP Can 330ml-",
                    Item_Prize = 250,
                    Quantity = int.Parse(tb.Text),
                    Total_prize = int.Parse(tb.Text) * 250,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();
            }

            bb2.Visibility = Visibility.Collapsed;
            ub.Visibility = Visibility.Collapsed;
            db.Visibility = Visibility.Collapsed;
            tb.Visibility = Visibility.Collapsed;
            ob.Visibility = Visibility.Collapsed;
            if (bb1.Visibility == Visibility.Collapsed)
            {
                bb1.Visibility = Visibility.Visible;
            }
            tb.Text = numValue.ToString();

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartList = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
            newCart.ItemsSource = cartList;

        }
        /******************c**********************/

        private void Bc1_Click(object sender, RoutedEventArgs e)
        {

            if (bc2.Visibility == Visibility.Collapsed)
            {
                bc2.Visibility = Visibility.Visible;
            }

            if (tc.Visibility == Visibility.Collapsed)
            {
                tc.Visibility = Visibility.Visible;
            }
            if (uc.Visibility == Visibility.Collapsed)
            {
                uc.Visibility = Visibility.Visible;
            }
            if (dc.Visibility == Visibility.Collapsed)
            {
                dc.Visibility = Visibility.Visible;
            }
            if (oc.Visibility == Visibility.Collapsed)
            {
                oc.Visibility = Visibility.Visible;
            }

        }
        private void Bc2_Click(object sender, RoutedEventArgs e)
        {
            bc2.Visibility = Visibility.Collapsed;
            uc.Visibility = Visibility.Collapsed;
            dc.Visibility = Visibility.Collapsed;
            tc.Visibility = Visibility.Collapsed;
            oc.Visibility = Visibility.Collapsed;

            if (bc1.Visibility == Visibility.Collapsed)
            {
                bc1.Visibility = Visibility.Visible;
            }
            tc.Text = numValue.ToString();
        }

        private void Uc_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tc.Text);
            if (input > 0)
            {
                int inout = input - 1;
                tc.Text = inout.ToString();
            }
        }

        private void Dc_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tc.Text);
            int inout = input + 1;
            tc.Text = inout.ToString();
        }
        private void oc_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D3",
                    Item_Name = "Pepsi PET",
                    Item_Prize = 300,
                    Quantity = int.Parse(tc.Text),
                    Total_prize = int.Parse(tc.Text) * 300,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();
            }

            bc2.Visibility = Visibility.Collapsed;
            uc.Visibility = Visibility.Collapsed;
            dc.Visibility = Visibility.Collapsed;
            tc.Visibility = Visibility.Collapsed;
            oc.Visibility = Visibility.Collapsed;
            if (bc1.Visibility == Visibility.Collapsed)
            {
                bc1.Visibility = Visibility.Visible;
            }
            tc.Text = numValue.ToString();

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
            newCart.ItemsSource = cartListF1;

        }
        private void Tc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /******************************d***************************************/

        private void Bd1_Click(object sender, RoutedEventArgs e)
        {
            if (bd2.Visibility == Visibility.Collapsed)
            {
                bd2.Visibility = Visibility.Visible;
            }

            if (td.Visibility == Visibility.Collapsed)
            {
                td.Visibility = Visibility.Visible;
            }
            if (ud.Visibility == Visibility.Collapsed)
            {
                ud.Visibility = Visibility.Visible;
            }
            if (dd.Visibility == Visibility.Collapsed)
            {
                dd.Visibility = Visibility.Visible;
            }
            if (od.Visibility == Visibility.Collapsed)
            {
                od.Visibility = Visibility.Visible;
            }
        }

        private void Bd2_Click(object sender, RoutedEventArgs e)
        {
            bd2.Visibility = Visibility.Collapsed;
            ud.Visibility = Visibility.Collapsed;
            dd.Visibility = Visibility.Collapsed;
            td.Visibility = Visibility.Collapsed;
            od.Visibility = Visibility.Collapsed;

            if (bd1.Visibility == Visibility.Collapsed)
            {
                bd1.Visibility = Visibility.Visible;
            }
            td.Text = numValue.ToString();
        }

        private void Ud_Click(object sender, RoutedEventArgs e)
        {

            int input = Convert.ToInt32(td.Text);
            if (input > 0)
            {
                int inout = input - 1;
                td.Text = inout.ToString();
            }
        }

        private void Dd_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(td.Text);
            int inout = input + 1;
            td.Text = inout.ToString();
        }
        private void od_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D4",
                    Item_Name = "Pepsi Black 330ml",
                    Item_Prize = 250,
                    Quantity = int.Parse(td.Text),
                    Total_prize = int.Parse(td.Text) * 250,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();
            }

            bd2.Visibility = Visibility.Collapsed;
            ud.Visibility = Visibility.Collapsed;
            dd.Visibility = Visibility.Collapsed;
            td.Visibility = Visibility.Collapsed;
            od.Visibility = Visibility.Collapsed;
            if (bd1.Visibility == Visibility.Collapsed)
            {
                bd1.Visibility = Visibility.Visible;
            }
            td.Text = numValue.ToString();

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
            newCart.ItemsSource = cartListF1;

        }

        private void Td_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /**********************e*********************/
        private void Be1_Click(object sender, RoutedEventArgs e)
        {
            if (be2.Visibility == Visibility.Collapsed)
            {
                be2.Visibility = Visibility.Visible;
            }

            if (te.Visibility == Visibility.Collapsed)
            {
                te.Visibility = Visibility.Visible;
            }
            if (ue.Visibility == Visibility.Collapsed)
            {
                ue.Visibility = Visibility.Visible;
            }
            if (de.Visibility == Visibility.Collapsed)
            {
                de.Visibility = Visibility.Visible;
            }
            if (oe.Visibility == Visibility.Collapsed)
            {
                oe.Visibility = Visibility.Visible;
            }
        }

        private void Be2_Click(object sender, RoutedEventArgs e)
        {
            be2.Visibility = Visibility.Collapsed;
            ue.Visibility = Visibility.Collapsed;
            de.Visibility = Visibility.Collapsed;
            te.Visibility = Visibility.Collapsed;
            oe.Visibility = Visibility.Collapsed;

            if (be1.Visibility == Visibility.Collapsed)
            {
                be1.Visibility = Visibility.Visible;
            }
            te.Text = numValue.ToString();
        }

        private void Ue_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(te.Text);
            if (input > 0)
            {
                int inout = input - 1;
                te.Text = inout.ToString();
            }
        }

        private void De_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(te.Text);
            int inout = input + 1;
            te.Text = inout.ToString();
        }


        private void oe_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D5",
                    Item_Name = "Pepsi Can 330ml ",
                    Item_Prize = 200,
                    Quantity = int.Parse(te.Text),
                    Total_prize = int.Parse(te.Text) * 200,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();
            }
            be2.Visibility = Visibility.Collapsed;
            ue.Visibility = Visibility.Collapsed;
            de.Visibility = Visibility.Collapsed;
            te.Visibility = Visibility.Collapsed;
            oe.Visibility = Visibility.Collapsed;
            if (be1.Visibility == Visibility.Collapsed)
            {
                be1.Visibility = Visibility.Visible;
            }
            te.Text = numValue.ToString();

            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
            newCart.ItemsSource = cartListF1;

        }
        private void Te_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /********************************f************************/
        private void Bf1_Click(object sender, RoutedEventArgs e)
        {
            if (bf2.Visibility == Visibility.Collapsed)
            {
                bf2.Visibility = Visibility.Visible;
            }

            if (tf.Visibility == Visibility.Collapsed)
            {
                tf.Visibility = Visibility.Visible;
            }
            if (uf.Visibility == Visibility.Collapsed)
            {
                uf.Visibility = Visibility.Visible;
            }
            if (df.Visibility == Visibility.Collapsed)
            {
                df.Visibility = Visibility.Visible;
            }
            if (of.Visibility == Visibility.Collapsed)
            {
                of.Visibility = Visibility.Visible;
            }
        }

        private void Bf2_Click(object sender, RoutedEventArgs e)
        {
            bf2.Visibility = Visibility.Collapsed;
            uf.Visibility = Visibility.Collapsed;
            df.Visibility = Visibility.Collapsed;
            tf.Visibility = Visibility.Collapsed;
            of.Visibility = Visibility.Collapsed;

            if (bf1.Visibility == Visibility.Collapsed)
            {
                bf1.Visibility = Visibility.Visible;
            }
            tf.Text = numValue.ToString();
        }

        private void Uf_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tf.Text);
            if (input > 0)
            {
                int inout = input - 1;
                tf.Text = inout.ToString();
            }

        }

        private void Df_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tf.Text);
            int inout = input + 1;
            tf.Text = inout.ToString();
        }
        private void of_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseReposi repository = new DatabaseReposi())
            {
                Class1 class1 = new Class1()
                {

                    Customer_Name = UsN,
                    Item_ID = "1D6",
                    Item_Name = " Mirinda Can 330ml ",
                    Item_Prize = 150,
                    Quantity = int.Parse(tf.Text),
                    Total_prize = int.Parse(tf.Text) * 150,

                };
                repository.class1s_set.Add(class1);
                repository.SaveChanges();
            }

            bf2.Visibility = Visibility.Collapsed;
            uf.Visibility = Visibility.Collapsed;
            df.Visibility = Visibility.Collapsed;
            tf.Visibility = Visibility.Collapsed;
            of.Visibility = Visibility.Collapsed;
            if (bf1.Visibility == Visibility.Collapsed)
            {
                bf1.Visibility = Visibility.Visible;
            }
            tf.Text = numValue.ToString();
            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess != 1).ToList();
            newCart.ItemsSource = cartListF1;

        }

        private void Tf_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void n_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void MenuItem_DelPat_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure want to delelte?\nAll details related this item will be lost.", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No))
            {
                Class1 SelPat = newCart.SelectedItem as Class1;
                if (SelPat == null) return;
                using (DatabaseReposi QueryDel = new DatabaseReposi())
                {
                    var Pat = QueryDel.class1s_set.Find(SelPat.Cart_ID1);
                    //cancel
                    Pat.Buy_Scussess = 2;
                    QueryDel.SaveChanges();
                }


                //  DelPrev();
                //  load();

            }


            DatabaseReposi repository1 = new DatabaseReposi();
            var cartListF1 = repository1.class1s_set.Where(b => b.Customer_Name == UsN && b.Buy_Scussess == 0).ToList();
            newCart.ItemsSource = cartListF1;

        }

        private void newCart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

