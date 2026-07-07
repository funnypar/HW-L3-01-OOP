namespace Library.Models
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            try
            {
                Books.Add(book);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding book: {ex.Message}", ex);
            }
        }

        public void BorrowBook(string title)
        {
            try
            {
                var book = Books.FirstOrDefault(b => b.Title == title && b.IsAvailable);
                if (book != null)
                {
                    book.IsAvailable = false;
                }
                else
                {
                    throw new Exception("Book not available");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }

        }

        public void ReturnBook(string title)
        {
            try
            {
                var book = Books.FirstOrDefault(b => b.Title == title && !b.IsAvailable);
                if (book != null)
                {
                    book.IsAvailable = true;
                }
                else
                {
                    throw new Exception("Book not found or already available");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }
    }
}
