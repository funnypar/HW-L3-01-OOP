namespace Library.Models
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int ISBN { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
