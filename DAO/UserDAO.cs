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

        public List<User> GetAll()
        {
            var users = new List<User>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT id_user, firstname, name, role, email, password FROM User;", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Firstname = reader.GetString("firstname"),
                            Name = reader.GetString("name"),
                            Role = reader.GetBoolean("role"),
                            Email = reader.GetString("email"),
                            Password = reader.GetString("password")
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving users: " + ex.Message);
                }
            }
            return users;
        }

        public User GetById(int id)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT id_user, firstname, name, role, email FROM User WHERE id_user = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Firstname = reader.GetString("firstname"),
                            Name = reader.GetString("name"),
                            Role = reader.GetBoolean("role"),
                            Email = reader.GetString("email")
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving user: " + ex.Message);
                }
            }
        }

        public void Create(User user, string password)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("INSERT INTO User (firstname, name, role, email, password) VALUES (@firstname, @name, @role, @email, SHA2(@password, 256));", connection);
                    command.Parameters.AddWithValue("@firstname", user.Firstname);
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error creating user: " + ex.Message);
                }
            }
        }

        public void Update(User user)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE User SET firstname = @firstname, name = @name, role = @role, email = @email WHERE id_user = @id;", connection);
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@firstname", user.Firstname);
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating user: " + ex.Message);
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("DELETE FROM User WHERE id_user = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting user: " + ex.Message);
                }
            }
        }

        public void UpdatePasswordByAdmin(int userId, string newPassword)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE User SET password = SHA2(@password, 256) WHERE id_user = @id;", connection);
                    command.Parameters.AddWithValue("@id", userId);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating password: " + ex.Message);
                }
            }
        }
    }
}
