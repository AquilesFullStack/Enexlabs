namespace enexlabs.Data
{
    public class UserProfile
    {   
        public int Id { get; set; }
        public User UserId { get; set; }
        public UserProfile UserProfileId { get; set; }
        public string CompletName { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string BornDate { get; set; }
        public string Picture { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
