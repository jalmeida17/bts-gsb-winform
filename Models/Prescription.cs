
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Prescription
{
    [Key]
    public int Id_Prescription { get; set; }

    [ForeignKey("Patient")]
    public int Id_Patients { get; set; }

    [ForeignKey("User")]
    public int Id_Users { get; set; }

    public int? Quantity { get; set; }

    public DateTime? Validity { get; set; }

    // Navigation properties
    public Patient Patient { get; set; }
    public User User { get; set; }
    public ICollection<Appartient> Appartients { get; set; } = new List<Appartient>();

    public Prescription()
    {
    }

    public Prescription(int id , int id_patient, int id_user, int? quantity, DateTime? validity)
    {
        Id_Prescription = id;
        Id_Patients = id_patient;
        Id_Users = id_user;
        Quantity = quantity;
        Validity = validity;
    }
}
