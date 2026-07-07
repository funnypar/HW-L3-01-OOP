namespace Hospital_Management.Models
{
    public class Person
    {
        public Person(string name, int age, long natinalId)
        {
            Name = name;
            Age = age;
            NationalId = natinalId;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public long NationalId { get; set; }
        public virtual string GetDetails()
        {
            return $"{Name} is {Age} with national Id : {NationalId}";
        }
    }
}
