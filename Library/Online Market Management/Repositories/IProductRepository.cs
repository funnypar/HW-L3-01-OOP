using Online_Market_Management.Models;

namespace Online_Market_Management.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product? GetProduct(string name);
        string? DeleteProduct(string name);
        string? AddProduct(Product product);
    }
}
