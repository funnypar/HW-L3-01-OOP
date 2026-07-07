using Library.Models;

namespace Library.Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library.Models.Library library = new Library.Models.Library();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("======================================");
                Console.WriteLine("        LIBRARY MANAGEMENT");
                Console.WriteLine("======================================\n");

                Console.ResetColor();

                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Show All Books");
                Console.WriteLine("5. Exit");

                Console.Write("\nChoose an option: ");
                string? choice = Console.ReadLine();

                Console.Clear();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddBook(library);
                            break;

                        case "2":
                            BorrowBook(library);
                            break;

                        case "3":
                            ReturnBook(library);
                            break;

                        case "4":
                            ShowBooks(library);
                            break;

                        case "5":
                            exit = true;
                            continue;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option!");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void AddBook(Library.Models.Library library)
        {
            Console.Write("Title : ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Author: ");
            string author = Console.ReadLine() ?? "";

            Console.Write("ISBN  : ");

            if (!int.TryParse(Console.ReadLine(), out int isbn))
            {
                throw new Exception("ISBN must be a number.");
            }

            Book book = new Book
            {
                Title = title,
                Author = author,
                ISBN = isbn,
                IsAvailable = true
            };

            library.AddBook(book);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBook added successfully.");
            Console.ResetColor();
        }

        static void BorrowBook(Library.Models.Library library)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine() ?? "";

            library.BorrowBook(title);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBook borrowed successfully.");
            Console.ResetColor();
        }

        static void ReturnBook(Library.Models.Library library)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine() ?? "";

            library.ReturnBook(title);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBook returned successfully.");
            Console.ResetColor();
        }

        static void ShowBooks(Library.Models.Library library)
        {
            if (!library.Books.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No books in the library.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"{"Title",-25} {"Author",-20} {"ISBN",-10} {"Status"}");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.ResetColor();

            foreach (var book in library.Books)
            {
                Console.WriteLine(
                    $"{book.Title,-25} {book.Author,-20} {book.ISBN,-10} {(book.IsAvailable ? "Available" : "Borrowed")}");
            }
        }
    }
}
