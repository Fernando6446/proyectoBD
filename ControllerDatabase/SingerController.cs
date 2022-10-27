using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using templates;
using System.Data.SqlClient;

namespace ControllerDatabase
{
    public class SingerController
    {

        SqlConnection connection;
        public SingerController()
        {
            this.connection = DBConnection.getConnection();
        }

        public List<Singer> getSingers()
        {
            this.connection.Open();
            List<templates.Singer> items = new List<templates.Singer>();
            string sql = "select * from dbo.Autor";
            SqlCommand cursor = new SqlCommand(sql, this.connection);
            SqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                DateTime date = reader.GetDateTime(2);
                string country = reader.GetString(3);
                string ocupacion = reader.GetString(4);
                DateTime date2 = reader.GetDateTime(5);
                int genre = reader.GetInt32(6);
                string awards = reader.GetString(7);
                templates.Singer singer = new templates.Singer(id, name, date, date2, country, ocupacion, genre, awards);
                items.Add(singer);
            }
            this.connection.Close();
            return items;
        }
    }
}
