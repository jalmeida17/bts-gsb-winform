using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace bts_gsb.DAO
{
    public class PatientDAO
    {
        private readonly Database db = new Database();

        public List<Patient> GetAll()
        {
            var patients = new List<Patient>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT pa.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM patients pa JOIN users u ON pa.id_users = u.id_user;", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var patient = new Patient(
                            reader.GetInt32("id_patients"),
                            reader.GetString("name"),
                            reader.GetString("firstname"),
                            reader.GetBoolean("gender"),
                            reader.IsDBNull(reader.GetOrdinal("age")) ? null : reader.GetInt32("age")
                        );
                        patient.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        patients.Add(patient);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving patients: " + ex.Message);
                }
            }
            return patients;
        }
        public Patient Get(int id)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT pa.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM patients pa JOIN users u ON pa.id_users = u.id_user WHERE pa.id_patients = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var patient = new Patient(
                            reader.GetInt32("id_patients"),
                            reader.GetString("name"),
                            reader.GetString("firstname"),
                            reader.GetBoolean("gender"),
                            reader.IsDBNull(reader.GetOrdinal("age")) ? null : reader.GetInt32("age")
                        );
                        patient.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        return patient;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving patient: " + ex.Message);
                }
            }
        }

        public void Create(Patient patient, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("INSERT INTO patients (name, firstname, gender, age, id_users) VALUES (@name, @firstname, @gender, @age, @id_users);", connection);
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@firstname", patient.Firstname);
                    command.Parameters.AddWithValue("@gender", patient.Gender);
                    command.Parameters.AddWithValue("@age", (object?)patient.Age ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_users", idUser);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error creating patient: " + ex.Message);
                }
            }
        }

        public void Update(Patient patient, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE patients SET name = @name, firstname = @firstname, gender = @gender, age = @age, id_users = @id_users WHERE id_patients = @id;", connection);
                    command.Parameters.AddWithValue("@id", patient.Id_Patients);
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@firstname", patient.Firstname);
                    command.Parameters.AddWithValue("@gender", patient.Gender);
                    command.Parameters.AddWithValue("@age", (object?)patient.Age ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_users", idUser);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating patient: " + ex.Message);
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
                    var command = new MySqlCommand("DELETE FROM patients WHERE id_patients = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting patient: " + ex.Message);
                }
            }
        }
    }
}
