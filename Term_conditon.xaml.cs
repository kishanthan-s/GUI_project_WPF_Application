using Homepage;
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
    /// Interaction logic for Term_conditon.xaml
    /// </summary>
    public partial class Term_conditon : Window
    {
        public Term_conditon()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main_win = new MainWindow();
            Main_win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Main_win = new MainWindow();
            Main_win.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

           Login Login_win = new Login();
            Login_win.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cus_feedback cus_feedback_win = new cus_feedback();
            cus_feedback_win.Show();
            this.Close();
        }

        private void food_Click_1(object sender, RoutedEventArgs e)
        {
            cus_feedback cus_feedback_win = new cus_feedback();
            cus_feedback_win.Show();
            this.Close();
        }

        private void sinup_Click_1(object sender, RoutedEventArgs e)
        {
            Signup Signup_win = new Signup();
            Signup_win.Show();
            this.Close();

        }
    }
}
