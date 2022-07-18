using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Pizze")]
public class Pizza
{
    [Key]
    public int id { get; set; }

    public string name { get; set; }

    [Column(TypeName = "text")]
    public string description { get; set; }

    public string fotoLink { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal prezzo { get; set; }

    public List<Ingrediente> listaIngredienti { get; set; }

    public Pizza(string name, string description, string fotoLink, decimal prezzo)
    {
        this.name = name;
        this.description = description;
        this.fotoLink = fotoLink;
        this.prezzo = prezzo;
    }

}

