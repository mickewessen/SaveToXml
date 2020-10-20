using Microsoft.VisualBasic;
using SaveToXml.Models;
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

namespace SaveToXml
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

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                information info = new information();
                info.FirstName = tbxfirstName.Text;
                info.LastName = tbxlastName.Text;
                info.Age = Convert.ToInt32(tbxAge.Text);
                info.City = tbxCity.Text;
                SaveXml.savedata(info, "micke1111.xml");
                msglabel.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            tbxfirstName.Text = "";
            tbxlastName.Text = "";
            tbxAge.Text = "";
            tbxCity.Text = "";
            msglabel.Visibility = Visibility.Hidden;
        }
    }
}
