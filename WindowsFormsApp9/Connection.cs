using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class Connection
    {
        private static String ConnectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        public static SqlConnection GetSqlConnection() { return new SqlConnection(ConnectionString); }
    }
}
