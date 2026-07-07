namespace University_Management.Models
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Guid StudentID { get; set; }
        public required string Major { get; set; }

        public void GetDetails()
        {
            try
            {
                Console.WriteLine($"Student ID: {StudentID}, Name: {Name}, Age: {Age}, Major: {Major}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting student details: {ex.Message}", ex);
            }
        }
    }
}
