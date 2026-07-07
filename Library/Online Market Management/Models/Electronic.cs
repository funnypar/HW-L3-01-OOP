using Online_Market_Management.Interfaces;

namespace Online_Market_Management.Models
{
    public class Electronic : Product, Idiscountable
    {
        public Electronic(string name, double price, int warrantyPeriod) : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }
        public int WarrantyPeriod { get; set; }
        public double Discount { get; set; } = 0;

        public void ApplyDiscount(double discount)
        {
            try
            {
                if (discount <= 0) { throw new Exception("The discount must be higher than 0."); }
                if (discount < Price)
                {
                    Price -= discount;
                    Discount = discount;
                    Console.WriteLine($"\n{discount} has been applied and new price is : {Price}");
                }
                else { throw new Exception($"Discount must be lower than the price : {Price}"); }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in apply discount: {ex.Message}", ex);
            }
        }

        public override void GetProductDetails()
        {
            try
            {
                Console.WriteLine($"Electronic Name: {Name}, Price: {Price}, Warranty: {WarrantyPeriod}, Discount: {(Discount != 0 ? Discount.ToString() : "None")}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting electronic details: {ex.Message}", ex);
            }
        }
    }
}
