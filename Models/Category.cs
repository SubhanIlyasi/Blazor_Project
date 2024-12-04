using System.ComponentModel.DataAnnotations;

namespace Ilyasi_Garments.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
