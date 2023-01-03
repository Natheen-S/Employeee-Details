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

namespace Employeee_Details
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string first = "";
            string address = txtbox_address.Text;
            string second = $"With great pleasure, I would like extend the following employment offer.\r\n \r\nPosition: {txtbox_jobtitle.Text}\r\nStart date: 10/12/2022\r\nSalary: 50,000 per month\r\n \r\nThis employment offer is contingent upon the successful \rcompletion of background check, drug screening, reference check. \rThis offer is not a contract of employment, and either party \rmay terminate employment at any time, with or without cause. \r\n \r\nSincerely, \r\n HR Manager.";
            first = $"Dear { txtbox_name.Text },";

            
            if (txtbox_name.Text != "" && txtbox_qualification.Text != "" && txtbox_address.Text != "" && txtbox_jobtitle.Text != "") 
            {
                offer ooffer = new offer();
                ooffer.lbl_address.Content = address;
                ooffer.lbl_one.Content= first ;
                ooffer.lbl_two.Content= second ;
                ooffer.Show();
            }
            else
            {
                MessageBox.Show("Fill all the details Correctly");
            }
        }
    }
}
