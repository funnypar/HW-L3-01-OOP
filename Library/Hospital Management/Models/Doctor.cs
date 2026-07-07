namespace Hospital_Management.Models
{
    public class Doctor : Person
    {
        public Doctor(string name, int age, long natinalId, string specialization) : base(name, age, natinalId)
        {
            Specialization = specialization;
        }

        public Guid DoctorId { get; } = Guid.NewGuid();
        public string Specialization { get; set; }

        public void Diagnose(Patient patient)
        {
            try
            {
                Console.WriteLine("\nPlease enter the issue: ");
                string userInput = Console.ReadLine().Trim();

                if (userInput.Length == 0)
                {
                    throw new Exception("Invalid Issue.");
                }

                patient.AddToMedicalHistory(userInput);
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error in adding issue : {ex.Message}", ex);
            }
        }
    }
}