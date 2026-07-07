namespace Online_Market_Management.Models
{
    public class Clothing : Product
    {
        public Clothing(string name, double price, string size, string material) : base(name, price)
        {
            Size = size;
            Material = material;
        }

        public string Size { get; set; }
        public string Material { get; set; }

        public override void GetProductDetails()
        {
            try
            {
                Console.WriteLine($"Clothing Name: {Name}, Price: {Price}, Size: {Size}, Material: {Material}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting clothing details: {ex.Message}", ex);
            }
        }
    }
}
