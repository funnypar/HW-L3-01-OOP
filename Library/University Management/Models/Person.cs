namespace University_Management.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetDetails()
        {
            try
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting details: {ex.Message}", ex);
            }
        }
    }
}
