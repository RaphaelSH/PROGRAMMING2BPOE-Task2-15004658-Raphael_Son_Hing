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

namespace Assignment
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
            frmWelcome wel = new frmWelcome();
            wel.ShowDialog();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSelect.Text.Equals("frmLogin"))
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
           
            else if (cmbSelect.Text.Equals("frmRe"))
            {
                frmRe re = new frmRe();
                re.ShowDialog(); ;
            }
            else if (cmbSelect.Text.Equals("frmResult"))
            {
                frmResult res = new frmResult();
                res.ShowDialog();
            }
            else if (cmbSelect.Text.Equals("frmTrial"))
            {
                frmTrial trial = new frmTrial();
                trial.ShowDialog(); 
            }
            else if (cmbSelect.Text.Equals("frmWelcome"))
            {
                frmWelcome wel = new frmWelcome();
                wel.ShowDialog(); ;
            }
        }

        private void btnNext_Copy_Click(object sender, RoutedEventArgs e)
        {
            frmRe re = new frmRe();
            re.ShowDialog(); ;
            this.Hide();
        }
    }
}
