namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class CheckoutDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Flavor { get; set; }
        public string Wight { get; set; }
    }
}