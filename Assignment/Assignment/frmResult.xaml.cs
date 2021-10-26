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
    /// Interaction logic for frmResult.xaml
    /// </summary>
    public partial class frmResult : Window
    {
        db_connection db = new db_connection();
        public frmResult()
        {
            InitializeComponent();
            db.customerConn = new OleDbConnection(db.connParam);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=assignment.mdb;";
            string strSql = "Select name, mark from tblStudent";
            OleDbConnection con = new OleDbConnection(connParam);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            //dataGridView1.DataSource = scores;
        }
    }
}
