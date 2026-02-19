namespace enexlabs.Data
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Origin { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
        public string? Observation { get; set; }

    }
}
