
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Prescription
{
    [Key]
    public int Id_Prescription { get; set; }

    [ForeignKey("Patient")]
    public int id_patient { get; set; }

    [ForeignKey("User")]
    public int id_user { get; set; }

    public DateTime? Validity { get; set; }

    // Navigation properties
    public Patient? Patient { get; set; }
    public User? User { get; set; }
    public ICollection<Appartient> Appartients { get; set; } = new List<Appartient>();

    public Prescription()
    {
    }

    public Prescription(int id , int id_patient, int id_user, DateTime? validity)
    {
        Id_Prescription = id;
        this.id_patient = id_patient;
        this.id_user = id_user;
        Validity = validity;
    }
}
