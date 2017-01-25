using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ExpiryDate { get; set; }

        public string Description { get; set; }
    }
}