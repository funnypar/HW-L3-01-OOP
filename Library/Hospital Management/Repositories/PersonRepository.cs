using Hospital_Management.Models;
using Hospital_Management.Repositories.Interfaces;

namespace Hospital_Management.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;

        public PersonRepository(IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
        }

        public List<Person> GetAllPersons()
        {
            try
            {
                var patients = _patientRepository.GetAllPatient().Cast<Person>();
                var doctors = _doctorRepository.GetAllDoctor().Cast<Person>();

                return patients.Concat(doctors).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting all persons: {ex.Message}", ex);
            }
        }

    }
}
