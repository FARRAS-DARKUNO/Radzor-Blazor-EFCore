using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SetupRadzorBlazor.Domain
{
    [Table("CarInventory")]
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Engine { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Color { get; set; }
    }
}
