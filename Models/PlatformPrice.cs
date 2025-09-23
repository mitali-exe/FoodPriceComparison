using System.ComponentModel.DataAnnotations;

namespace FoodPriceComparison.Models
{
    public class PlatformPrice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string DishName { get; set; }

        [Required]
        [MaxLength(100)]
        public string PlatformName { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
