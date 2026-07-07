using Online_Market_Management.Models;
using Online_Market_Management.Repositories;

namespace Online_Market_Management.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct()
        {
            try
            {
                Console.WriteLine("Choose product type:\n");
                Console.WriteLine("1. Product");
                Console.WriteLine("2. Electric");
                Console.WriteLine("3. Clothes\n");
                Console.Write("Choice: ");

                string? choice = Console.ReadLine();

                Console.Write("\nEnter product name: ");
                string? productName = Console.ReadLine()?.Trim();

                Console.Write("\nEnter price: ");
                string? productPriceStr = Console.ReadLine()?.Trim();

                if (!double.TryParse(productPriceStr, out double price))
                    throw new Exception("Price was not in the correct format.");


                switch (choice)
                {
                    case "1":
                        var product = new Product(productName!, price);
                        _productRepository.AddProduct(product);
                        break;

                    case "2":
                        Console.Write("Enter warranty (months): ");
                        int warranty = int.Parse(Console.ReadLine()!);

                        var elProduct = new Electronic(productName!, price, warranty);

                        Console.Write("Enter discount: ");
                        double discount = double.Parse(Console.ReadLine()!);
                        if(discount > 0)
                        {
                            elProduct.ApplyDiscount(discount);
                        }

                        _productRepository.AddProduct(elProduct);

                        break;

                    case "3":
                        Console.Write("Enter size: ");
                        string size = Console.ReadLine()!;
                        Console.Write("Enter material: ");
                        string material = Console.ReadLine()!;

                        var clProduct = new Clothing(productName!, price, size, material);
                        _productRepository.AddProduct(clProduct);
                        break;

                    default:
                        throw new Exception("Invalid product type.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"There is a problem in adding a product: {ex.Message}", ex);
            }
        }

        public void DeleteProduct()
        {
            try
            {
                Console.Write("Enter product name: ");

                var userInput = Console.ReadLine()?.Trim().ToLower();

                var deletedProduct = _productRepository.DeleteProduct(userInput!);
                if (deletedProduct != null)
                {
                    Console.WriteLine($"The product '{deletedProduct}' has been deleted.");
                }
                else
                {
                    Console.WriteLine($"The product not found.");
                }
            }
            catch (Exception ex) {
                throw new Exception($"There was an error in deleting product",ex);
            }
        }

        public void GetProduct()
        {
            try
            {
                Console.Write("Enter product name: ");

                var userInput = Console.ReadLine()?.Trim().ToLower();

                var product = _productRepository.GetProduct(userInput!);

                if (product == null)
                    throw new Exception($"The product '{userInput}' does not exist.");

                product.GetProductDetails();
            }
            catch (Exception ex) {
                throw new Exception($"There is an error in getting products: {ex.Message}",ex);
            }
        }

        public void GetProducts()
        {
            try
            {
                var products = _productRepository.GetProducts();

                foreach (var item in products)
                {
                    item.GetProductDetails();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in {ex.Message}",ex);
            }
        }
    }
}
