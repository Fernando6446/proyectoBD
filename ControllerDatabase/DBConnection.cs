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
        public SqlConnection conn;
        public string connectionString;
        public DBConnection()
        {
            this.connectionString = "Data Source=localhost;Initial Catalog=Proyecto;User ID=as;Password=1234";
            this.conn = new SqlConnection();
        }

        public SqlConnection getConnection()
        {
            return this.conn;
        }
    }
}
