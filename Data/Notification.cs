namespace enexlabs.Data
{
    public class Notification
    {
        public int IdNotification { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime DataSent { get; set; }
    }
}