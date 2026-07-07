using Hospital_Management.Models;
using Hospital_Management.Repositories.Interfaces;
using Hospital_Management.Services.Interfaces;

namespace Hospital_Management.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void AddPatient()
        {
            try
            {
                Console.WriteLine("\nEnter Name: ");
                string name = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter Age: ");
                string ageStr = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter NationalId: ");
                string nationalIdStr = Console.ReadLine().Trim();

                if (!int.TryParse(ageStr, out int age))
                {
                    throw new Exception("Invalid Age.");
                }
                if (age <= 0)
                {
                    throw new Exception("The Age must be higher than 0.");
                }

                if (!long.TryParse(nationalIdStr, out long nationalId))
                {
                    throw new Exception("Invalid NationalId.");
                }
                if (nationalId <= 1000000000)
                {
                    throw new Exception("The NationalId must be something like '2000000003' with 10 chars");
                }

                Patient newPatient = new Patient(name, age, nationalId);

                _patientRepository.AddPatient(newPatient);
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error in adding patient {ex.Message}", ex);
            }
        }
        public void DeletePatient()
        {
            try
            {
                Console.WriteLine("\nEnter patient id: ");
                string patientIdStr = Console.ReadLine().Trim();
                if (Guid.TryParse(patientIdStr, out Guid patientId))
                {
                    _patientRepository.RemovePatient(patientId);
                }
                else
                {
                    throw new Exception("Invalid Id.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in deleting patient : {ex.Message}", ex);
            }
        }
        public void ShowAllPatients()
        {
            try
            {
                var patients = _patientRepository.GetAllPatient();
                foreach (var patient in patients)
                {
                    Console.WriteLine(patient.GetDetails());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in shwoing patient: {ex.Message}", ex);
            }
        }
        public void ShowPatientDetails()
        {
            try
            {
                Console.WriteLine("\nEnter patient id: ");
                string patientIdStr = Console.ReadLine().Trim();
                if (Guid.TryParse(patientIdStr, out Guid patientId))
                {
                    var patient = _patientRepository.GetPatientByPatientId(patientId);
                    if (patient == null) { throw new Exception("No patient found."); }
                    Console.WriteLine($"\n{patient.GetDetails()}");
                }
                else
                {
                    throw new Exception("Invalid Id.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in showing patient details : {ex.Message}", ex);
            }
        }
        public void AddIssueToPatient()
        {
            try
            {
                Console.WriteLine("\nEnter patient id: ");
                string patientIdStr = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter issue: ");
                string issue = Console.ReadLine().Trim();

                if (issue.Length == 0) { throw new Exception("Enter an Issue."); }

                if (Guid.TryParse(patientIdStr, out Guid patientId))
                {
                    _patientRepository.AddIssueToPatient(patientId, issue);
                }
                else
                {
                    throw new Exception("Invalid Id.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in deleting patient : {ex.Message}", ex);
            }
        }
    }
}
