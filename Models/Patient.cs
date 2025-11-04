using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Patient
{
    [Key]
    public int Id_Patients { get; set; }

    [ForeignKey("User")]
    public int Id_Users { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required, MaxLength(100)]
    public string Firstname { get; set; }

    public int? Age { get; set; }

    public bool? Gender { get; set; } // false = Femme, true = Homme

    // Navigation properties
    public User User { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public Patient()
    {
    }

    public Patient(int id, string name, string firstname, bool gender, int? age)
    {
        Id_Patients = id;
        Name = name;
        Firstname = firstname;
        Gender = gender;
        Age = age;
    }
}