using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(63, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Category { get; set; }

        [Required]
        [StringLength(63)]
        public string Manifacturer { get; set; }

        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        
        [StringLength(255, MinimumLength = 1)]
        public string Description { get; set; }

        // Decimal er alltid [Required]
        [Range(1,99999)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
