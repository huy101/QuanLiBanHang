using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    //Class chức năng
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand SqlCommand;
        SqlDataReader SqlDataReader;
        public Taikhoan CheckLogin(string query)
        {
            Taikhoan taikhoan = null as Taikhoan;
            //Connect database
            using (SqlConnection sqlconection = Connection.GetSqlConnection())
            {
                sqlconection.Open();
                SqlCommand = new SqlCommand(query, sqlconection);
                SqlDataReader = SqlCommand.ExecuteReader();
                while (SqlDataReader.Read())
                {
                    var username = SqlDataReader.GetString(0);
                    var pass = SqlDataReader.GetString(1);
                    var role = SqlDataReader.GetInt32(2);
                    taikhoan = new Taikhoan(SqlDataReader.GetString(0), SqlDataReader.GetString(1), SqlDataReader.GetInt32(2));
                }
                sqlconection.Close();
            }
            return taikhoan;
        }
    }
}
