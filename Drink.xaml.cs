﻿using System;
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
    /// Interaction logic for Drink.xaml
    /// </summary>
    public partial class Drink : Page
    {
        public Drink()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new Drink1();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new Drink2();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            myFrame.Content = new Drink3();

        }
    }
}
