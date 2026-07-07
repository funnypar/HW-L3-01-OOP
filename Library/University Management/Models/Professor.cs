namespace University_Management.Models
{
    public class Professor : Person
    {
        public Professor(string name, int age) : base(name, age)
        {
        }

        public Guid ProffesorID { get; set; }
        public required string Subject { get; set; } 

        public void GetDetails()
        {
            try
            {
                Console.WriteLine($"Professor ID: {ProffesorID}, Name: {Name}, Age: {Age}, Subject: {Subject}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting professor details: {ex.Message}", ex);
            }
        }

    }
}
