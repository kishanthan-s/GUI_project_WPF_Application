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
    /// Interaction logic for SwichOff.xaml
    /// </summary>
    public partial class SwichOff : Window
    {
        public SwichOff()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string addminEmail = "kishanthan@gmail.com";
            string password = "admin";

            if(addminEmail== textBoxEmail.Text && password == passwordBox1.Password)
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Are you sure want to Shutdown this Software?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No))
                {
                    Application.Current.Shutdown();

                }

                Application.Current.Shutdown();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
