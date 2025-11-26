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
                    var command = new MySqlCommand(@"SELECT pa.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM Patient pa JOIN User u ON pa.id_user = u.id_user;", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var patient = new Patient(
                            reader.GetInt32("id_patient"),
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
                    var command = new MySqlCommand(@"SELECT pa.*, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM Patient pa JOIN User u ON pa.id_user = u.id_user WHERE pa.id_patient = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var patient = new Patient(
                            reader.GetInt32("id_patient"),
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
                    var command = new MySqlCommand("INSERT INTO Patient (name, firstname, gender, age, id_user) VALUES (@name, @firstname, @gender, @age, @id_user);", connection);
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@firstname", patient.Firstname);
                    command.Parameters.AddWithValue("@gender", patient.Gender);
                    command.Parameters.AddWithValue("@age", (object?)patient.Age ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_user", idUser);
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
                    var command = new MySqlCommand("UPDATE Patient SET name = @name, firstname = @firstname, gender = @gender, age = @age, id_user = @id_user WHERE id_patient = @id;", connection);
                    command.Parameters.AddWithValue("@id", patient.id_patient);
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@firstname", patient.Firstname);
                    command.Parameters.AddWithValue("@gender", patient.Gender);
                    command.Parameters.AddWithValue("@age", (object?)patient.Age ?? DBNull.Value);
                    command.Parameters.AddWithValue("@id_user", idUser);
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
                    var command = new MySqlCommand("DELETE FROM Patient WHERE id_patient = @id;", connection);
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
