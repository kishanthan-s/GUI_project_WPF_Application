﻿using Homepage;
using Online_Food_Order_Software.Database;
using Online_Food_Order_Software.Models;
using System;
using System.Linq;
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
    /// Interaction logic for DeliverDetails.xaml
    /// </summary>
    public partial class DeliverDetails : Window
    {
        public DeliverDetails()
        {
            InitializeComponent();
            load();
            txtBarcode.Focus();
        }

        public void load()
        {

            DatabaseReposi repository = new DatabaseReposi();

            var cartList = repository.supliers_set.ToList();
            CartGrid.ItemsSource = cartList;


        }

        private void CartGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void MenuItem_DelPat_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }


        public void Delete()
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure want to delelte?\nAll details related patient will be lost.", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No))
            {
                Suplier SelPat = CartGrid.SelectedItem as Suplier;
                if (SelPat == null) return;


                using (DatabaseReposi QueryDel = new DatabaseReposi())
                {
                    var Pat = QueryDel.supliers_set.Find(SelPat.Province);

                    QueryDel.supliers_set.Remove(Pat);
                    QueryDel.SaveChanges();
                }
                load();

            }



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Feedback_List feedback_List = new Feedback_List();
            feedback_List.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            add();
        }

        public void addSuplier()
        {


            DatabaseReposi DbSuplier = new DatabaseReposi();
            Suplier suplier = new Suplier()
            {

                Suplier_ID = Convert.ToInt32(txtBarcode.Text),
                Name = txtItemName.Text,
                Contact_No = txtQuantity.Text,
                Vehical_No = txtSalePrice.Text,
                Province = cmbProvince.Text,


            };

            DbSuplier.supliers_set.Add(suplier);
            DbSuplier.SaveChanges();
        }
        public void clear()
        {
            txtBarcode.Text = "";
            txtItemName.Text = "";
            txtQuantity.Text = "";
            txtSalePrice.Text = "";
            cmbProvince.Text = "";


        }

        public void update()
        {

            DatabaseReposi repository = new DatabaseReposi();
            var PatUpdate = repository.supliers_set.Where((a => (a.Province == cmbProvince.Text))).FirstOrDefault();



            PatUpdate.Suplier_ID =Convert.ToInt32( txtBarcode.Text);
            PatUpdate.Name = txtItemName.Text;
            PatUpdate.Contact_No = txtQuantity.Text;
            PatUpdate.Vehical_No = txtSalePrice.Text;
           // PatUpdate.Province = cmbProvince.Text;
            

            repository.SaveChanges();
            MessageBox.Show("Successfully Updated!!");
        }

        public void add()
        {
            if (txtBarcode.Text != "" && txtItemName.Text != "" && txtQuantity.Text != "" && txtSalePrice.Text != "")
            {
                cmbProvince.IsEnabled = true;

                DatabaseReposi strock = new DatabaseReposi();

                if (strock.supliers_set.Where(a => (a.Province == cmbProvince.Text)).FirstOrDefault() != null)
                {
                    update();
                    load();
                    clear();
                }
                else
                {


                    addSuplier();
                    load();
                    clear();
                    MessageBox.Show("Successfully added!!");

                }
            }
            else
            {
                MessageBox.Show("Fill All before Add!!");
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void MenuItem_EditPat_Click(object sender, RoutedEventArgs e)
        {
            RetriveSuplier();

        }
     
            public void RetriveSuplier()
        {
            Suplier SelPat = CartGrid.SelectedItem as Suplier;
            if (SelPat == null) return;


            using (DatabaseReposi QueryDel = new DatabaseReposi())
            {
                var Pat = QueryDel.supliers_set.Find(SelPat.Province);


                txtBarcode.Text = Convert.ToString(Pat.Suplier_ID);
                txtItemName.Text = Pat.Name;
                txtQuantity.Text = Pat.Contact_No;
                txtSalePrice.Text = Pat.Vehical_No;
                cmbProvince.Text = Pat.Province;

                cmbProvince.IsEnabled = false;


            }
        }
        
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtItemName.Focus();
            }

            switch (e.Key)
            {



                case Key.F5:
                    add();
                    break;


                case Key.F9:
                    clear();
                    //  PaymentBtn();
                    break;


            }

        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtQuantity.Focus();
            }

            switch (e.Key)
            {



                case Key.F5:
                    add();
                    break;


                case Key.F9:
                    clear();
                    //  PaymentBtn();
                    break;


            }

        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                 txtSalePrice.Focus();
            }

            switch (e.Key)
            {



                case Key.F5:
                    add();
                    break;


                case Key.F9:
                    clear();
                    //  PaymentBtn();
                    break;


            }


        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                 cmbProvince.Focus();
            }

            switch (e.Key)
            {



                case Key.F5:
                    add();
                    break;


                case Key.F9:
                    clear();
                    break;


            }


        }

        private void cmbProvince_KeyDown(object sender, KeyEventArgs e)
        {
            add();
        }
    }
}
