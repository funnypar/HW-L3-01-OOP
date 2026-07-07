using University_Management.Models;

namespace University_Management.Mock
{
    public class MockData
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student("Alice", 20) { StudentID = Guid.NewGuid(), Major = "Mathematics" },
                new Student("Bob", 21) { StudentID = Guid.NewGuid(), Major = "Physics" },
                new Student("Charlie", 22) { StudentID = Guid.NewGuid(), Major = "Computer Science" },
                new Student("David", 23) { StudentID = Guid.NewGuid(), Major = "Chemistry" },
                new Student("Emma", 19) { StudentID = Guid.NewGuid(), Major = "Biology" },
                new Student("Frank", 24) { StudentID = Guid.NewGuid(), Major = "Mechanical Engineering" },
                new Student("Grace", 22) { StudentID = Guid.NewGuid(), Major = "Electrical Engineering" },
                new Student("Henry", 20) { StudentID = Guid.NewGuid(), Major = "Civil Engineering" },
                new Student("Isabella", 21) { StudentID = Guid.NewGuid(), Major = "Economics" },
                new Student("Jack", 23) { StudentID = Guid.NewGuid(), Major = "Business Administration" },
                new Student("Karen", 22) { StudentID = Guid.NewGuid(), Major = "Psychology" },
                new Student("Liam", 20) { StudentID = Guid.NewGuid(), Major = "Software Engineering" },
                new Student("Mia", 19) { StudentID = Guid.NewGuid(), Major = "Statistics" },
                new Student("Noah", 24) { StudentID = Guid.NewGuid(), Major = "Architecture" },
                new Student("Olivia", 21) { StudentID = Guid.NewGuid(), Major = "English Literature" },
                new Student("Peter", 22) { StudentID = Guid.NewGuid(), Major = "History" },
                new Student("Quinn", 23) { StudentID = Guid.NewGuid(), Major = "Political Science" },
                new Student("Ryan", 20) { StudentID = Guid.NewGuid(), Major = "Artificial Intelligence" },
                new Student("Sophia", 21) { StudentID = Guid.NewGuid(), Major = "Data Science" },
                new Student("Thomas", 22) { StudentID = Guid.NewGuid(), Major = "Cybersecurity" }
            };
            return students;
        }

        public List<Professor> GetProfessors()
        {
            List<Professor> professors = new List<Professor>
            {
                new Professor("Dr. Smith", 45) { ProffesorID = Guid.NewGuid(), Subject = "Mathematics" },
                new Professor("Dr. Johnson", 50) { ProffesorID = Guid.NewGuid(), Subject = "Physics" },
                new Professor("Dr. Williams", 55) { ProffesorID = Guid.NewGuid(), Subject = "Computer Science" },
                new Professor("Dr. Brown", 60) { ProffesorID = Guid.NewGuid(), Subject = "Chemistry" },
                new Professor("Dr. Jones", 48) { ProffesorID = Guid.NewGuid(), Subject = "Biology" }
            };

            return professors;
        }
    }
}
