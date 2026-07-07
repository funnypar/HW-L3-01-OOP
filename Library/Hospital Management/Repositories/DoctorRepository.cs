using Hospital_Management.Mock;
using Hospital_Management.Models;
using Hospital_Management.Repositories.Interfaces;

namespace Hospital_Management.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public DoctorRepository(MockData mockData)
        {
            _doctors = mockData.MockDoctors();
        }
        private List<Doctor> _doctors;
        public List<Doctor> GetAllDoctor()
        {
            try
            {
                return _doctors;
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting doctors : {ex.Message}", ex);
            }
        }
        public Doctor? GetDoctor(Guid doctorId)
        {
            try
            {
                return _doctors.FirstOrDefault(doctor => doctor.DoctorId == doctorId);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting doctor : {ex.Message}", ex);
            }
        }
        public Doctor? GetPatientByNationalId(long nationalId)
        {
            try
            {
                return _doctors.FirstOrDefault(p => p.NationalId == nationalId);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting patient: {ex.Message}", ex);
            }
        }
    }
}
