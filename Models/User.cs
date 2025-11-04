using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{

    //ceci est une propriété, elle permet d'acceder en lecture et en écriture
    //à notre attribut de classe via les méthodes get et set
    public int Id { get; set; }
    public string Name { get; set; }
    public string Firstname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool Role { get; set; }

    //ceci est le constructeur par défaut
    //il permet de créer une instance de la classe qui nous permettra d'acceder
    //aux méthodes et propriétés de celle ci 
    public User() { }

    //ceci est une surcharge du constructeur, elle permettra la création d'objet User
    //qui sera instancié avec les variables passées en parametres
    public User(int id, string name, string firstname, bool role)
    {
        this.Id = id;
        this.Name = name;
        this.Firstname = firstname;
        this.Role = role;
    }
}