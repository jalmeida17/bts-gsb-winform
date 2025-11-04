using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Medicine
{
    [Key]
    public int Id_Medicine { get; set; }

    [ForeignKey("User")]
    public int Id_Users { get; set; }

    [Required, MaxLength(150)]
    public string Name { get; set; }

    [MaxLength(150)]
    public string Molecule { get; set; }

    [MaxLength(100)]
    public string Dosage { get; set; }

    public string Description { get; set; }

    // Navigation properties
    public User User { get; set; }
    public ICollection<Appartient> Appartients { get; set; } = new List<Appartient>();

    public Medicine() { }

    public Medicine(int id, string name, string molecule, string dosage, string description)
    {
        Id_Medicine = id;
        Name = name;
        Molecule = molecule;
        Dosage = dosage;
        Description = description;
    }
}
