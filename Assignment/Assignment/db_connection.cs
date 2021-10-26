using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class db_connection
    {
        public OleDbConnection customerConn;
        public OleDbCommand oleDbCmd = new OleDbCommand();
        public String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=assignment.mdb;";
    }
}
