using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace bts_gsb.DAO
{
    public class PrescriptionDAO
    {
        private readonly Database db = new Database();

        public List<Prescription> GetAll()
        {
            var prescriptions = new List<Prescription>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT p.*, pa.id_patients, pa.name AS patient_name, pa.firstname AS patient_firstname, pa.gender AS patient_gender, pa.age AS patient_age, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM prescriptions p JOIN patients pa ON p.id_patients = pa.id_patients JOIN users u ON p.id_users = u.id_user;", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var prescription = new Prescription(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_patients"),
                            reader.GetInt32("id_users"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity"),
                            reader.IsDBNull(reader.GetOrdinal("validity")) ? null : reader.GetDateTime("validity")
                        );
                        // Fill Patient
                        prescription.Patient = new Patient
                        {
                            Id_Patients = reader.GetInt32("id_patients"),
                            Name = reader.GetString("patient_name"),
                            Firstname = reader.GetString("patient_firstname"),
                            Gender = reader.IsDBNull(reader.GetOrdinal("patient_gender")) ? null : reader.GetBoolean("patient_gender"),
                            Age = reader.IsDBNull(reader.GetOrdinal("patient_age")) ? null : reader.GetInt32("patient_age")
                        };
                        // Fill User
                        prescription.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        prescriptions.Add(prescription);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving prescriptions: " + ex.Message);
                }
            }
            return prescriptions;
        }
        public Prescription Get(int id)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"SELECT p.*, pa.id_patients, pa.name AS patient_name, pa.firstname AS patient_firstname, pa.gender AS patient_gender, pa.age AS patient_age, u.id_user, u.name AS user_name, u.firstname AS user_firstname, u.role AS user_role, u.email AS user_email FROM prescriptions p JOIN patients pa ON p.id_patients = pa.id_patients JOIN users u ON p.id_users = u.id_user WHERE p.id_prescription = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var prescription = new Prescription(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_patients"),
                            reader.GetInt32("id_users"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity"),
                            reader.IsDBNull(reader.GetOrdinal("validity")) ? null : reader.GetDateTime("validity")
                        );
                        prescription.Patient = new Patient
                        {
                            Id_Patients = reader.GetInt32("id_patients"),
                            Name = reader.GetString("patient_name"),
                            Firstname = reader.GetString("patient_firstname"),
                            Gender = reader.IsDBNull(reader.GetOrdinal("patient_gender")) ? null : reader.GetBoolean("patient_gender"),
                            Age = reader.IsDBNull(reader.GetOrdinal("patient_age")) ? null : reader.GetInt32("patient_age")
                        };
                        prescription.User = new User
                        {
                            Id = reader.GetInt32("id_user"),
                            Name = reader.GetString("user_name"),
                            Firstname = reader.GetString("user_firstname"),
                            Role = reader.GetBoolean("user_role"),
                            Email = reader.GetString("user_email")
                        };
                        return prescription;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving prescription: " + ex.Message);
                }
            }
        }

        public void Create(Prescription prescription, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("INSERT INTO prescriptions (id_patients, id_users, quantity, validity) VALUES (@id_patients, @id_users, @quantity, @validity);", connection);
                    command.Parameters.AddWithValue("@id_patients", prescription.Id_Patients);
                    command.Parameters.AddWithValue("@id_users", idUser);
                    command.Parameters.AddWithValue("@quantity", (object?)prescription.Quantity ?? DBNull.Value);
                    command.Parameters.AddWithValue("@validity", (object?)prescription.Validity ?? DBNull.Value);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error creating prescription: " + ex.Message);
                }
            }
        }

        public void Update(Prescription prescription, int idUser)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE prescriptions SET id_patients = @id_patients, id_users = @id_users, quantity = @quantity, validity = @validity WHERE id_prescription = @id;", connection);
                    command.Parameters.AddWithValue("@id", prescription.Id_Prescription);
                    command.Parameters.AddWithValue("@id_patients", prescription.Id_Patients);
                    command.Parameters.AddWithValue("@id_users", idUser);
                    command.Parameters.AddWithValue("@quantity", (object?)prescription.Quantity ?? DBNull.Value);
                    command.Parameters.AddWithValue("@validity", (object?)prescription.Validity ?? DBNull.Value);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating prescription: " + ex.Message);
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
                    var command = new MySqlCommand("DELETE FROM prescriptions WHERE id_prescription = @id;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting prescription: " + ex.Message);
                }
            }
        }

        // Get a single prescription by patient ID (returns the first found)
        public Prescription GetByPatientId(int patientId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM prescriptions WHERE id_patients = @patientId LIMIT 1;", connection);
                    command.Parameters.AddWithValue("@patientId", patientId);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Prescription(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_patients"),
                            reader.GetInt32("id_users"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity"),
                            reader.IsDBNull(reader.GetOrdinal("validity")) ? null : reader.GetDateTime("validity")
                        );
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving prescription by patient ID: " + ex.Message);
                }
            }
        }

        // Get all prescriptions by patient ID
        public List<Prescription> GetAllByPatientId(int patientId)
        {
            var prescriptions = new List<Prescription>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM prescriptions WHERE id_patients = @patientId;", connection);
                    command.Parameters.AddWithValue("@patientId", patientId);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var prescription = new Prescription(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_patients"),
                            reader.GetInt32("id_users"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity"),
                            reader.IsDBNull(reader.GetOrdinal("validity")) ? null : reader.GetDateTime("validity")
                        );
                        prescriptions.Add(prescription);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving prescriptions by patient ID: " + ex.Message);
                }
            }
            return prescriptions;
        }
    }
}
