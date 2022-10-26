using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControllerDatabase
{
    public class DBConnection
    {
        public static SqlConnection getConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=Proyecto;User ID=sa;Password=1234";
            return new SqlConnection(connectionString);
        }
    }
}
