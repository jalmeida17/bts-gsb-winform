using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Medicine
{
    [Key]
    public int Id_Medicine { get; set; }

    [Browsable(false)]
    [ForeignKey("User")]
    public int id_user { get; set; }

    [Required, MaxLength(150)]
    public string Name { get; set; }

    [MaxLength(150)]
    public string Molecule { get; set; }

    [MaxLength(100)]
    public string Dosage { get; set; }

    public string Description { get; set; }

    // Navigation properties
    [Browsable(false)]
    public User User { get; set; }
    [Browsable(false)]
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
