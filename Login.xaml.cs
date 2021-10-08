using Online_Food_Order_Software.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                //MessageBox.Show("Enter an email.");
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                //MessageBox.Show("Enter a valid email.");
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string email = textBoxEmail.Text;
                string password = passwordBox1.Password;
                using (DatabaseReposi reposi = new DatabaseReposi())
                {
                    var users = reposi.buyer.FirstOrDefault(a => a.EmailID.Equals(email));
                    {
                        if (users != null)
                        {
                            if (users.Password.Equals(password))
                            {
                                MessageBox.Show("Login sucessfull");
                                Promotion Promo_win = new Promotion();
                                Promo_win.Show();
                                this.Close();
                            }
                            else
                            {
                                errormessage.Text = "Sorry! Please enter existing password.";
                                 MessageBox.Show("Sorry! Please enter existing password.");

                            }
                        }
                        else
                        {
                            errormessage.Text = "Sorry! Please enter existing emailid/password.";
                            MessageBox.Show("Sorry! Please enter existing emailid/password.");

                        }
                    }

                }
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Signup Signup_Win = new Signup();
            Signup_Win.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Signup Signup_Win = new Signup();
            Signup_Win.Show();
            this.Close();
        }
    }
}
