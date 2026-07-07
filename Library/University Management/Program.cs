using University_Management.Mock;

namespace University_Management
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mock = new MockData();
            var students = mock.GetStudents();
            var professors = mock.GetProfessors();

            Console.WriteLine("Proffesors:\n");

            foreach (var professor in professors)
            {
                professor.GetDetails();
            }

            Console.WriteLine("\nStudents:\n");

            foreach (var student in students)
            {
                student.GetDetails();
            }
        }
    }
}
