using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace bts_gsb.DAO
{
    public class MedicineDAO
    {
        private readonly Database db = new Database();

        public List<Medicine> GetAll()
        {
            var medicines = new List<Medicine>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT m.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM Medicine m JOIN User u ON m.id_user = u.id_user;", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var medicine = new Medicine(
                            reader.GetInt32("id_medicine"),
                            reader.GetString("name"),
                            reader.GetString("molecule"),
                            reader.GetString("dosage"),
                            reader.GetString("description")
                        );
                        medicine.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        medicines.Add(medicine);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving medicines: " + ex.Message);
                }
            }
            return medicines;
        }
        public Medicine GetByName(string name)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT m.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM medicines m JOIN User u ON m.id_user = u.id_user WHERE m.name = @name;", connection);
                    command.Parameters.AddWithValue("@name", name);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var medicine = new Medicine(
                            reader.GetInt32("id_medicine"),
                            reader.GetString("name"),
                            reader.GetString("molecule"),
                            reader.GetString("dosage"),
                            reader.GetString("description")
                        );
                        medicine.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        return medicine;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving medicine by name: " + ex.Message);
                }
            }
        }

        public List<Medicine> GetByMolecule(string molecule)
        {
            var medicines = new List<Medicine>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM medicines WHERE molecule = @molecule;", connection);
                    command.Parameters.AddWithValue("@molecule", molecule);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var medicine = new Medicine(
                            reader.GetInt32("id_medicine"),
                            reader.GetString("name"),
                            reader.GetString("molecule"),
                            reader.GetString("dosage"),
                            reader.GetString("description")
                        );
                        medicines.Add(medicine);
                    }
                    return medicines;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving medicines by molecule: " + ex.Message);
                }
            }
        }

        public void Create(Medicine medicine, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("INSERT INTO medicines (name, molecule, dosage, description, id_user) VALUES (@name, @molecule, @dosage, @description, @id_user);", connection);
                    command.Parameters.AddWithValue("@name", medicine.Name);
                    command.Parameters.AddWithValue("@molecule", medicine.Molecule);
                    command.Parameters.AddWithValue("@dosage", medicine.Dosage);
                    command.Parameters.AddWithValue("@description", medicine.Description);
                    command.Parameters.AddWithValue("@id_user", idUser);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error creating medicine: " + ex.Message);
                }
            }
        }

        public void Update(Medicine medicine, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE medicines SET name = @name, molecule = @molecule, dosage = @dosage, description = @description, id_user = @id_user WHERE id_medicine = @id;", connection);
                    command.Parameters.AddWithValue("@id", medicine.Id_Medicine);
                    command.Parameters.AddWithValue("@name", medicine.Name);
                    command.Parameters.AddWithValue("@molecule", medicine.Molecule);
                    command.Parameters.AddWithValue("@dosage", medicine.Dosage);
                    command.Parameters.AddWithValue("@description", medicine.Description);
                    command.Parameters.AddWithValue("@id_user", idUser);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating medicine: " + ex.Message);
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
                    var command = new MySqlCommand("DELETE FROM medicines WHERE id_medicine = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting medicine: " + ex.Message);
                }
            }
        }
    }
}
