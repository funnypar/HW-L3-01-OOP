using Hospital_Management.Models;

namespace Hospital_Management.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        public Doctor? GetDoctor(Guid doctorId);
        public List<Doctor> GetAllDoctor();
        public Doctor? GetPatientByNationalId(long nationalId);
    }
}
