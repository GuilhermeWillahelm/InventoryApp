namespace InventoryApp.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string NameInventory { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
