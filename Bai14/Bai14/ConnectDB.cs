using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Bai14
{
    class ConnectDB
    {
        public static SqlConnection Connect(string source, string nameDB, string user, string pass)
        {
            string conString = "Data Source = " + source + ";Initial Catalog = " + nameDB + ";Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }
    }
}
