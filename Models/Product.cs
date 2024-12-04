using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ilyasi_Garments.Models
{
    public class Product
    {
        [Key]
        [Column("Id")]
        public string Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Type")]
        public string Type { get; set; }

        [Required]
        [Column("Price")]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Column("Quantity")]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Column("ImageUrl")]
        public string ImageUrl { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Color")]
        public string Color { get; set; }

        [Column("FabricMaterial")]
        public string FabricMaterial { get; set; }
    }
}
