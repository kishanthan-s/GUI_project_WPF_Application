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
    /// Interaction logic for FoodWindow.xaml
    /// </summary>
    public partial class FoodWindow : Window
    {
        public FoodWindow()
        {
            InitializeComponent();

            myFood.Content = new Food(UsN);

        



            using (DatabaseReposi repository = new DatabaseReposi())
            {
                int x = 0;

                DatabaseReposi DatabaseReposi = new DatabaseReposi();
                foreach (var cat in DatabaseReposi.supliers_set)
                {
                    if (cat.Name.ToString() != "")
                    {

                        x = 1;
                        break;

                    }
                    else
                    {
                        break;
                    }
                }




                if (x == 0)

                {

                    int j = 10;
                    for (int k = 1; k < j; k++)
                    {
                        if (k == 1)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 1,
                                Name = "Nishantha Silva",
                                Contact_No = "0716512452",
                                Vehical_No = "ER1235",
                                Province = "Sabaragamuwa",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }

                        if (k == 2)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 2,
                                Name = "Tharindu Premarathna",
                                Contact_No = "0756214584",
                                Vehical_No = "HG1425",
                                Province = "Southern",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 3)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 3,
                                Name = "Nuwan Perera",
                                Contact_No = "0356214586",
                                Vehical_No = "PL2568",
                                Province = "Western",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 4)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 4,
                                Name = "Pawan Charuka",
                                Contact_No = "0142536954",
                                Vehical_No = "YH7521",
                                Province = "Uva",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 5)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 5,
                                Name = "Anusha Piyashan",
                                Contact_No = "0786541258",
                                Vehical_No = "NH2564",
                                Province = "Central",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 6)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 6,
                                Name = "Bhanuka Yohan",
                                Contact_No = "0781426354",
                                Vehical_No = "AG6541",
                                Province = "Eastern",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 7)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 7,
                                Name = "Hashan Sadaruwan",
                                Contact_No = "0789541236",
                                Vehical_No = "QW3214",
                                Province = "North Western",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 8)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 8,
                                Name = "Imalka Narada",
                                Contact_No = "0153624589",
                                Vehical_No = "KM7854",
                                Province = "North Central",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }
                        if (k == 9)
                        {
                            Suplier suplier = new Suplier()
                            {

                                Suplier_ID = 9,
                                Name = "Daminda Lakshan",
                                Contact_No = "0742365148",
                                Vehical_No = "RD6521",
                                Province = "Northern",

                            };
                            repository.supliers_set.Add(suplier);
                            repository.SaveChanges();

                        }



                    }


                }
            }
            //

            ////

            ////

            ////

            ////

            //////////////////
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DrinkWindow drinkWindow = new DrinkWindow();
            drinkWindow.Show();
            this.Close();

        }
        private string UsN;
        public FoodWindow(string UN) : this()
        {
            n.Text = UN;
        }



        private void myFood_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Global.DirectToLogout();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Global.DirectToHome();
            this.Close();

            /*
            SwichOff swich = new SwichOff();
            swich.ShowDialog();

            */
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Promotion promotion = new Promotion();
            promotion.Show();
            this.Close();
        }
    }
}