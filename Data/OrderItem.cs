namespace enexlabs 

public class OrderItem
{
	{
       public string Id { get; set; }
	   public OrderItem Order { get; set; }
	   public OrderItem OrderId { get; set; }
       public string ProductId { get; set; }
	   public string Quantity { get; set; }
	   public string UnitPrice { get; set; }
       public string UnitPriceUnit { get; set; }
	   public string SubTotal { get; set; }
	}
}
