using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADODataConnection
{
    public static class ConnectionDB
    {
        public static SqlConnection DBConOpen()
        {
            SqlConnection conn = new SqlConnection();
            string cString = @"Data Source=SAAD\sqlexpress2014;Initial Catalog=Products;Integrated Security=True";
            
            conn.ConnectionString = cString;
            conn.Open();
            return conn;
        }        
    }
}
