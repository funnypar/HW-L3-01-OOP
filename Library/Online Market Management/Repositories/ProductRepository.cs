using Online_Market_Management.Models;

namespace Online_Market_Management.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = [];

        public string? AddProduct(Product product)
        {
            try
            {
                _products.Add(product);
                return product.Name;
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error to add product : {ex.Message}", ex);
            }
        }

        public string? DeleteProduct(string name)
        {
            try
            {
                var product = _products.FirstOrDefault(p => p.Name == name);
                if (product != null)
                {
                    _products.Remove(product);
                    return product?.Name;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error in deleting product : {ex.Message}",ex);
            }
        }

        public Product? GetProduct(string name)
        {
            try
            {
                return _products.FirstOrDefault(p => p.Name.ToLower() == name);
            }
            catch (Exception ex) {
                throw new Exception($"There is an error in getting product : {ex.Message}", ex);
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _products;
            }
            catch (Exception ex) {
                throw new Exception($"There is an error in getting products: {ex.Message}",ex);
            }
        }

    }
}
