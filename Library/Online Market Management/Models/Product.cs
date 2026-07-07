namespace Online_Market_Management.Models
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual void GetProductDetails()
        {
            try
            {
                Console.WriteLine($"Product Name: {Name}, Price: {Price}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting product details: {ex.Message}", ex);
            }
        }
    }
}
