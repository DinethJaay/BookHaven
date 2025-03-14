namespace BookHaven.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }  
        public int CustomerId { get; set; }  
        public int BookId { get; set; }  
        public int Quantity { get; set; } 
        public decimal Price { get; set; }  
        public string Status { get; set; }  
        public string DeliveryType { get; set; }  
        public DateTime OrderDate { get; set; }  
        public decimal Subtotal { get; set; }  
        public Customer Customer { get; set; }  
        public Book Book { get; set; }
    }
}
