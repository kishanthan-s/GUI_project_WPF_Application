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

        public static int CustomerID = 0;

        public static string UserName = "Isuru";

        public static string ProvinceG = null;

        public static string addres = null;

        public static string province = null;

        public static string addressMethod = null;

        public static string PaymentMethod = null;

        public static void DirectToHome()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            //  this.close();
        }

        public static void DirectToLogout()
        {
            Login login = new Login();
            login.Show();
            //  this.close();
        }

    }


}
