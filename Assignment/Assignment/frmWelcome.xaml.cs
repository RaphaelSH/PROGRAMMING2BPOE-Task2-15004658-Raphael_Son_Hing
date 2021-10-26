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

namespace Assignment
{
    /// <summary>
    /// Interaction logic for frmWelcome.xaml
    /// </summary>
    public partial class frmWelcome : Window
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void EXITToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            //Exit apllication 
        }


        private void SEARCHToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ShowDialog();
        }

        private void LOGOUTToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Hide();
        }







        private void RESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResult result = new frmResult();
            result.ShowDialog();
        }

        private void MASTERToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
