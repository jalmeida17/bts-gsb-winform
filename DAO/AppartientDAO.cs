using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace bts_gsb.DAO
{
    public class AppartientDAO
    {
        private readonly Database db = new Database();

        /// <summary>
        /// Add a medicine to a prescription with a specific quantity
        /// </summary>
        public void AddMedicineToPrescription(int prescriptionId, int medicineId, int quantity)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("INSERT INTO Appartient (id_prescription, id_medicine, quantity) VALUES (@id_prescription, @id_medicine, @quantity);", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding medicine to prescription: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Remove a medicine from a prescription
        /// </summary>
        public void RemoveMedicineFromPrescription(int prescriptionId, int medicineId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("DELETE FROM Appartient WHERE id_prescription = @id_prescription AND id_medicine = @id_medicine;", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error removing medicine from prescription: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Update the quantity of a medicine in a prescription
        /// </summary>
        public void UpdateMedicineQuantity(int prescriptionId, int medicineId, int quantity)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("UPDATE Appartient SET quantity = @quantity WHERE id_prescription = @id_prescription AND id_medicine = @id_medicine;", connection);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating medicine quantity: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Get all medicines for a specific prescription with their quantities
        /// </summary>
        public List<Appartient> GetMedicinesForPrescription(int prescriptionId)
        {
            var appartients = new List<Appartient>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"
                        SELECT a.*, m.name, m.molecule, m.dosage, m.description, m.id_user
                        FROM Appartient a 
                        JOIN Medicine m ON a.id_medicine = m.id_medicine 
                        WHERE a.id_prescription = @id_prescription;", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var appartient = new Appartient(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_medicine"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity")
                        );
                        
                        // Fill the Medicine navigation property
                        appartient.Medicine = new Medicine(
                            reader.GetInt32("id_medicine"),
                            reader.GetString("name"),
                            reader.GetString("molecule"),
                            reader.GetString("dosage"),
                            reader.GetString("description")
                        );

                        appartients.Add(appartient);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving medicines for prescription: " + ex.Message);
                }
            }
            return appartients;
        }

        /// <summary>
        /// Get all prescriptions that contain a specific medicine
        /// </summary>
        public List<Appartient> GetPrescriptionsForMedicine(int medicineId)
        {
            var appartients = new List<Appartient>();
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand(@"
                        SELECT a.*, p.id_patient, p.id_user, p.validity
                        FROM Appartient a 
                        JOIN Prescription p ON a.id_prescription = p.id_prescription 
                        WHERE a.id_medicine = @id_medicine;", connection);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var appartient = new Appartient(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_medicine"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity")
                        );
                        
                        // Fill the Prescription navigation property
                        appartient.Prescription = new Prescription(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_patient"),
                            reader.GetInt32("id_user"),
                            reader.IsDBNull(reader.GetOrdinal("validity")) ? null : reader.GetDateTime("validity")
                        );

                        appartients.Add(appartient);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving prescriptions for medicine: " + ex.Message);
                }
            }
            return appartients;
        }

        /// <summary>
        /// Check if a medicine is already in a prescription
        /// </summary>
        public bool MedicineExistsInPrescription(int prescriptionId, int medicineId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT COUNT(*) FROM Appartient WHERE id_prescription = @id_prescription AND id_medicine = @id_medicine;", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error checking if medicine exists in prescription: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Get a specific Appartient record
        /// </summary>
        public Appartient Get(int prescriptionId, int medicineId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM Appartient WHERE id_prescription = @id_prescription AND id_medicine = @id_medicine;", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.Parameters.AddWithValue("@id_medicine", medicineId);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Appartient(
                            reader.GetInt32("id_prescription"),
                            reader.GetInt32("id_medicine"),
                            reader.IsDBNull(reader.GetOrdinal("quantity")) ? null : reader.GetInt32("quantity")
                        );
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving appartient record: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Remove all medicines from a prescription
        /// </summary>
        public void RemoveAllMedicinesFromPrescription(int prescriptionId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand("DELETE FROM Appartient WHERE id_prescription = @id_prescription;", connection);
                    command.Parameters.AddWithValue("@id_prescription", prescriptionId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error removing all medicines from prescription: " + ex.Message);
                }
            }
        }
    }
}