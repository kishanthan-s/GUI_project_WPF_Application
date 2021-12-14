using Online_Food_Order_Software;
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

namespace Homepage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Login Login_Win = new Login();
            Login_Win.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Signup Signup_Win = new Signup();
           Signup_Win.Show();
           this.Close();
        }

        private void Signup_butt_Click(object sender, RoutedEventArgs e)
        {
            Global.MainMenuSelect = "False";

            Login Login_Win = new Login();
            Login_Win.Show();
            this.Close();
            //go to login

            /*  Promotion Promo_win = new Promotion();
              Promo_win.Show();
              this.Close();

              */
        }

        private void Home_butt_Click(object sender, RoutedEventArgs e)
        {
            Global.MainMenuSelect = "True";
            Login Login_Win = new Login();
            Login_Win.Show();
            this.Close();            /*FoodWindow Main_win = new FoodWindow();
            Main_win.Show();
            this.Close();

            */
        }

        private void addmin_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login Admincheck = new Admin_Login();
            Admincheck.Show();
            this.Close();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            SwichOff shutdown = new SwichOff();
            shutdown.Show();
            this.Close();
        }
    }
}
