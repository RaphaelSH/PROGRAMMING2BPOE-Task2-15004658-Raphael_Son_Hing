using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {

        db_connection db = new db_connection();
        public frmLogin()
        {
            InitializeComponent();
            db.customerConn = new OleDbConnection(db.connParam);

        }

        private void invalid()
        {
            MessageBox.Show("Incorrect username and password entered", "Invalid credentials");
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
             Boolean found = false;
            String strUsername = this.txtname.Text;
            String strPassword = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().
   ComputeHash(System.Text.Encoding.Default.GetBytes(this.txtpass.Password)));

            if (this.txtname.Text.Equals(""))
            {
                MessageBox.Show("Enter the username");
            }
            else if (this.txtpass.Password.Equals(""))
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select *from tblStudent", db.customerConn);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, "tblStudent");
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    { 
                        if (strUsername == dataRow["name"].ToString() && strPassword == dataRow["password"].ToString())
                        {
                            found = true;
                            this.Hide();
                            frmTrial trial = new frmTrial();
                        trial.ShowDialog();
                        }
                    }
                    if (found == false)
                    {
                        invalid();
                    }
                    db.customerConn.Close();
                
                
                
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            this.txtname.Text = "";
            this.txtpass.Password = "";
        }
        
    }
}
