using Hospital_Management.Models;

namespace Hospital_Management.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        void RemovePatient(Guid patientId);
        public Patient? GetPatientByPatientId(Guid patientId);
        public List<Patient> GetAllPatient();
        public void AddIssueToPatient(Guid patientId, string issue);
    }
}
