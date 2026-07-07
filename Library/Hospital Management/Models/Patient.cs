namespace Hospital_Management.Models
{
    public class Patient : Person
    {
        public Patient(string name, int age, long natinalId) : base(name, age, natinalId)
        {
        }

        public Guid PatientId { get; } = Guid.NewGuid();
        public List<string> MedicalHistory { get; set; } = [];

        public void AddToMedicalHistory(string issue)
        {
            try
            {
                MedicalHistory.Add(issue);
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error in adding issue: {ex.Message}", ex);
            }
        }
        public override string GetDetails()
        {
            string medicalHistoryText = MedicalHistory.Count > 0
                ? string.Join(", ", MedicalHistory)
                : "No medical history";

            return $"{Name} is {Age} years old with National ID: {NationalId}, " +
                   $"Patient ID: {PatientId}, " +
                   $"Medical History: {medicalHistoryText}";
        }
    }
}
