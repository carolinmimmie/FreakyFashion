using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreakyFashion.Domain;//gruppera domain klasser 

public class Product//Skapar upp en klass
{
    public int Id { get; set; }//primärnyckel

    [MaxLength(50)]//begränsar längden på en sträng - påverkar hur migreringen ser ut 
    public required string Name { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public required decimal Price { get; set; }

}