using Online_Market_Management.Repositories;
using Online_Market_Management.Services;

namespace Online_Market_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            ProductService productService = new ProductService(productRepository);
            Menu(productService);
        }


        public static void Menu(IProductService productService)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("========================================");
                    Console.WriteLine("     ONLINE PRODUCT MANAGEMENT");
                    Console.WriteLine("========================================");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.WriteLine(" 1. Add Product");
                    Console.WriteLine(" 2. Show All Products");
                    Console.WriteLine(" 3. Show Product Details");
                    Console.WriteLine(" 4. Delete Product");
                    Console.WriteLine(" 5. Exit");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Select an option: ");
                    Console.ResetColor();

                    string? choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("\nAdd Product selected.");
                            productService.AddProduct();
                            break;

                        case "2":
                            Console.WriteLine("\nShow All Products selected.\n");
                            productService.GetProducts();
                            break;

                        case "3":
                            Console.WriteLine("\nShow Product Details selected.\n");
                            productService.GetProduct();
                            break;

                        case "4":
                            Console.WriteLine("\nDelete Product selected.\n");
                            productService.DeleteProduct();
                            break;

                        case "5":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nGoodbye!");
                            Console.ResetColor();
                            exit = true;
                            continue;

                        default:
                            throw new Exception("Invalid menu option.");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nError: {ex.Message}");
                    Console.ResetColor();
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
