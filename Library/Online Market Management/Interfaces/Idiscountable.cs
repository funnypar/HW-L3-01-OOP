namespace Online_Market_Management.Interfaces
{
    public interface Idiscountable
    {
        Double Discount { get; set; }
        void ApplyDiscount(double discount);
    }
}
