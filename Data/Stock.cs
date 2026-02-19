using enexlabs.Data;

namespace enexlabs
{
    public class Stock
    {
        public int IdStock { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int QuantityAvailable { get; set; }
        public int MinimunQuantity { get; set; }
        public string Localization { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}