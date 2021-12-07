using Homepage;
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
    /// Interaction logic for Feedback_List.xaml
    /// </summary>
    public partial class Feedback_List : Window
    {
        public Feedback_List()
        {
            InitializeComponent();
            using (DatabaseReposi reposit = new DatabaseReposi())
            {
                Feedback Feedback_res = new Feedback();

                var Feedback_list = reposit.response.ToList();
                dataGrid.ItemsSource = Feedback_list;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SwichOff swich = new SwichOff();
            swich.ShowDialog();
        }
    }
}
