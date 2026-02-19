namespace enexlabs.Data
{
    public enum PaymentMethod
    {
        Cartao,
        Pix,
        Boleto
    }

    public enum PaymentStatus
    {
        Aprovado,
        Recusado,
        Pendente
    }

    public class Payment
    {
        public int IdPayment { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Value { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime DatePayment { get; set; }
        public string CodeTransaction { get; set; }
    }
}
