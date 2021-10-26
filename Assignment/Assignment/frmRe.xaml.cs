using System;
using System.Collections.Generic;
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
    /// Interaction logic for frmRe.xaml
    /// </summary>
    public partial class frmRe : Window
    {
        db_connection db = new db_connection();
        public frmRe()
        {
            InitializeComponent();
            db.customerConn = new OleDbConnection(db.connParam);
        }

        String strPassword = "N";
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtname.Text.Equals(""))
            {
                MessageBox.Show("enter the name");
            }
          
            else if (this.txtpass.Password.Equals(""))
            {
                MessageBox.Show("enter password");
            }
            else if (this.txtcpass.Password.Equals(""))
            {
                //Reenter passord to confirm option added
                MessageBox.Show("enter confirm password");
            }
            else if (this.txtpass.Password.Equals(this.txtcpass.Password))
            {
                strPassword = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().
   ComputeHash(System.Text.Encoding.Default.GetBytes(this.txtpass.Password)));
                db.customerConn.Open();
                db.oleDbCmd.Connection = db.customerConn;
                db.oleDbCmd.CommandText = "insert into tblStudent(name, password) values (" +
                    this.txtname.Text + ",'" +
                    strPassword + "');";
                int temp = db.oleDbCmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    this.txtname.Text = "";
                    this.txtpass.Password = "";

                    MessageBox.Show("Student Successfuly Added!!!", "SAVED");
                }

                else
                {
                    MessageBox.Show("Record Fail to Added");
                }

                db.customerConn.Close();


            }
            else
            {
                MessageBox.Show("retype your password");
                this.txtpass.Password = "";
                this.txtcpass.Password = "";
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Hide();
        }
    }
}
