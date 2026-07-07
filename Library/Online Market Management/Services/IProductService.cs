using Online_Market_Management.Models;

namespace Online_Market_Management.Services
{
    public interface IProductService
    {
        void AddProduct();
        void DeleteProduct();
        void GetProduct();
        void GetProducts();
    }
}
