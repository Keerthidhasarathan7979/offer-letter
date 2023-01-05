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
using System.Xaml;

namespace offer_letter_project
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

        private void txtsub_Click(object sender, RoutedEventArgs e)
        {
            txtname.Text.ToUpper();
            string name = Convert.ToString(txtname.Text);
            txtjob.Text.ToUpper();
            string job = Convert.ToString(txtjob.Text);
            int salary = Convert.ToInt32(txtsal.Text);
            string address = Convert.ToString(txtadd.Text);
            string final  = " Let us know if we can answer any questions- you can reach me by calling 0788564876 or email mabey@TY.com";




            string content1 = string.Format("  Hi Dear {0}" + "\n" + "\n" + "\n" + " congratulation! We were hugely impressed by you during the interview process " + "\n" + "and excited for your potential to grow with Juro"+ "\n" +"we offer you account executive job!",name ,job ,salary);

            Window2 msg = new Window2();
            msg.lbladd.Content = address;
            msg.lblcontent.Content = content1;
            msg.lblfinal.Content = final;
            msg.Show();
          
            
            
        }
    }
}
