namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class InventoryCreateDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string? Flavor { get; set; }
        public string? Wight { get; set; }
    }
    public class InventoryReadDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string? Flavor { get; set; }
        public string? Wight { get; set; }
    }
    public class InventoryUpdateDto
    {
        public int Quantity { get; set; }
        public string? Flavor { get; set; }
        public string? Wight { get; set; }
    }
}