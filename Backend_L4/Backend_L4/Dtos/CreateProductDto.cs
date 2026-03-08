using System.ComponentModel.DataAnnotations;

namespace Backend_L4.Dtos
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }
    }
}