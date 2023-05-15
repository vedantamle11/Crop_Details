namespace CropDeal_WebAPI.DTO
{
    public class Invoicedto
    {
        public int Quantity { get; set; }
        public double Price { get; set;}
        public string? Payment_Mode { get; set; }
        public string Status { get; set; } = "Payment Pending";
    }
}
