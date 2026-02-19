namespace enexlabs
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IdFatherCategory { get; set; }
        public Category? FatherCategory { get; set; }
        public string Status { get; set; }
    }
}