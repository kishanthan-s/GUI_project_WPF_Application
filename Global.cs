using Homepage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software
{
    public static class Global
    {
        public static int PromoTotalBill = 0;

        public static int cartlBill = 0;

        public static int totalBill = 0;

        public static string Email = null;

        public static int CustomerID =0;

        public static string UserName = null;

        public static string ProvinceG = null;

        public static string addres = null;

        public static string province = null;

        public static string addressMethod = null;

        public static string PaymentMethod = null;


        public static string CustomerName = null;
        public static string CustomerEmail = null;
        public static string CustomerProvince = null;
        public static string AddressEdite = null;


        public static string MainMenuSelect = null;

        public static void DirectToHome()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            
        }

        public static void DirectToLogout()
        {
            Login login = new Login();
            login.Show();
            
        }
        public static void DirectToCart()
        {
            Cart cart = new Cart();
            cart.Show();

        }


        public static void DirectToMenu()
        {
            FoodWindow foodWindow = new FoodWindow();
            foodWindow.Show();

        }


    }


}
