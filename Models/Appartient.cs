
using System.ComponentModel.DataAnnotations.Schema;

public class Appartient
{
    [ForeignKey("Prescription")]
    public int Id_Prescription { get; set; }

    [ForeignKey("Medicine")]
    public int Id_Medicine { get; set; }

    // Navigation properties
    public Prescription Prescription { get; set; }
    public Medicine Medicine { get; set; }

    public Appartient() { 
    }

    public Appartient(int id_prescription, int id_medicine) {
        Id_Prescription = id_prescription;
        Id_Medicine = id_medicine;
    }
}
