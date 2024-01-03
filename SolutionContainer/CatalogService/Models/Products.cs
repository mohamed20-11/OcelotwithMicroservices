using System.ComponentModel.DataAnnotations;

namespace CatalogService.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
