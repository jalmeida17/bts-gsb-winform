using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bts_gsb.DAO
{
    public class UserDAO
    {
        private readonly Database db = new Database();

        public User Login(string email, string password)
        {
            int id;
            string name, firstname;
            bool role;

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = "SELECT * FROM User WHERE email = @email AND password = @password;";
                    myCommand.Parameters.AddWithValue("@email", email);
                    myCommand.Parameters.AddWithValue("@password", password);

                    using var MyReader = myCommand.ExecuteReader();
                    {
                        if (MyReader.Read())
                        {
                            id = MyReader.GetInt32("id_user");
                            name = MyReader.GetString("name");
                            firstname = MyReader.GetString("firstname");
                            role = MyReader.GetBoolean("role");

                        }
                        else
                        {
                            return null;
                        }
                    }
                    connection.Close();
                    User user = new User(id, name, firstname, role);
                    return user;

                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving user: " + ex.Message);
                }
            }
        }
    }
}
