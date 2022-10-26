using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using templates;

namespace ControllerDatabase
{
    public class GenreController
    {
        public SqlConnection connection;
        public GenreController()
        {
            this.connection = DBConnection.getConnection();
        }

        public  List<Genre> List()
        {
            this.connection.Open();
            List<templates.Genre> items = new List<templates.Genre>();
            string sql = "select * from dbo.Genero";
            SqlCommand cursor = new SqlCommand(sql, this.connection);
            SqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                templates.Genre genre = new templates.Genre(id, name);
                items.Add(genre);
            }
            this.connection.Close();
            return items;
        }
    }
}
