using System.ComponentModel.DataAnnotations;

namespace EndangeredSpecies.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SpeciesId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
