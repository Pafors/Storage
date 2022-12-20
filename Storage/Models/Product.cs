using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(60)]
        [Display(Name = "Item name")]
        public string Name { get; set; }

        [Range(0, int.MaxValue,
            ErrorMessage = "Price must be between {1} and {2}")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "A category is required")]
        public string Category { get; set; }

        [StringLength(60)]
        public string Shelf { get; set; }

        [Required(ErrorMessage = "A count value is required")]
        [Range(0, int.MaxValue,
            ErrorMessage = "Count must be between {1} and {2}")]
        [Display(Name = "Item count")]
        public int Count { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

    }
}
