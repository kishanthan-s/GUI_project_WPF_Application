using Online_Food_Order_Software.Database;
using Online_Food_Order_Software.Models;
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
    /// Interaction logic for cus_feedback.xaml
    /// </summary>
    /// 

    static class CusID
    {
        public static string cusid;
    }
    public partial class cus_feedback : Window
    {
        public cus_feedback()
        {
            InitializeComponent();
        }

      

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textEmail.Focus();
            }
            else if (!Regex.IsMatch(textEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textEmail.Select(0, textEmail.Text.Length);
                textEmail.Focus();
            }
            else if (!Regex.IsMatch(textPhone_number.Text, "\\A[0-9]{10}\\z"))
            {
                errormessage1.Text = "Enter a valid phone number";


            }
            else
            {
                using (DatabaseReposi reposit = new DatabaseReposi())
                {
                    Feedback Feedbacks = new Feedback
                    {
                        ID = textPhone_number.Text,
                        Name = textName.Text,
                        Email = textEmail.Text,
                        Phone_number = textPhone_number.Text,
                        Subject = textSubject.Text,
                        Message = textMessage.Text,

                    };
                    reposit.response.Add(Feedbacks);
                    reposit.SaveChanges();
                    thanks thanks_win = new thanks();
                    thanks_win.Show();
                    


                }
                CusID.cusid = textPhone_number.Text;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Term_conditon term_condi_win = new Term_conditon();
            term_condi_win.Show();
            Close();
        }
    }
}
