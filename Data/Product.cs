using System.ComponentModel;

namespace enexlabs.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int sku { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public Category CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
