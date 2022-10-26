using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControllerDatabase
{
    public class UserController
    {
        public SqlConnection connection;
        public UserController()
        {
            this.connection = DBConnection.getConnection();
        }

        public bool userExist(String user, String pass)
        {
            this.connection.Open();
            String sql = "select * from Usuario where usuario='" + user + "' and pass='" + pass + "'";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                this.connection.Close();
                return true;
            }
            this.connection.Close();
            return false;
        }

        public void createUser(String user, String email,String phone, String pass)
        {
            this.connection.Open();
            String sql = "insert into Usuario(usuario, correo, tel, pass)values('" + user + "', '"+email+"', '"+phone+"', '"+pass+"')";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}














