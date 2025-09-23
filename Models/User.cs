using System.ComponentModel.DataAnnotations;

namespace FoodPriceComparison.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }  // store hashed password

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
