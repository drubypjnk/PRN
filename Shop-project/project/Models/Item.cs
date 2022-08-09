namespace project.Models
{
    public class Item
    {
        public Product Product { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public Item(Product product, int quantity, double price)
        {
            Product = product;
            this.quantity = quantity;
            this.price = price;
        }

        public Item()
        {
        }
    }
}
