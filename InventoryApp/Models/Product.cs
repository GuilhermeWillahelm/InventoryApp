namespace InventoryApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string NameProduct { get; set; } = string.Empty;
        public string DescriptionProduct { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
