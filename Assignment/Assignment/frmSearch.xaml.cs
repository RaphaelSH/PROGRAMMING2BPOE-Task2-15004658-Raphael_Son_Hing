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
    /// Interaction logic for frmSearch.xaml
    /// </summary>
    public partial class frmSearch : Window
    {
        db_connection db = new db_connection();

        public frmSearch()
        {
            InitializeComponent();
            db.customerConn = new OleDbConnection(db.connParam);

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Search funtion
            Boolean found = false;

            OleDbDataAdapter dataAdapter =

                new OleDbDataAdapter("select * from tblStudent where mark = " +

                this.txtuname.Text, db.customerConn);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "employees");



            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {

                this.txtname.Text = dataRow["name"].ToString();

                this.txtclg.Text = dataRow["clgname"].ToString();

                this.txtcontact.Text = dataRow["contactno"].ToString();

                this.txtemail.Text = dataRow["email"].ToString();

                found = true;

            }

            if (found == false)
            {

                MessageBox.Show("No customer information found!!!", "No Data");

            }

            db.customerConn.Close();
        }
    }
}
