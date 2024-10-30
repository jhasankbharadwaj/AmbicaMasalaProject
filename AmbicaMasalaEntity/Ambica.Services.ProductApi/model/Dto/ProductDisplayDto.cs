using System.ComponentModel.DataAnnotations;

namespace Ambica.Services.ProductApi.model.Dto
{
    public class ProductDisplayDto
    {
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Availability { get; set; }
    }
}
