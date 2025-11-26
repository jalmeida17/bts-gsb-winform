using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                    myCommand.CommandText = "SELECT * FROM User WHERE email = @email AND password = SHA2(@password, 256);";
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

        public User UpdatePassword(string email, string oldpassword, string newpassword)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = "UPDATE User SET password = SHA2(@newpassword, 256) WHERE password = SHA2(@oldpassword, 256) AND email = @email";
                    myCommand.Parameters.AddWithValue("@oldpassword", oldpassword);
                    myCommand.Parameters.AddWithValue("@newpassword", newpassword);
                    myCommand.Parameters.AddWithValue("@email", email);

                    int rowsAffected = myCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Old password incorrect or no matching user found.");

                    connection.Close();
                    
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating password : " + ex.Message);
                }
            }   
        }
    }
}
