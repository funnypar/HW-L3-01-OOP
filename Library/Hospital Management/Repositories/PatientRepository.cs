using Hospital_Management.Mock;
using Hospital_Management.Models;
using Hospital_Management.Repositories.Interfaces;

namespace Hospital_Management.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public PatientRepository(MockData mockData)
        {
            _patients = mockData.MockPatients();
        }

        private List<Patient> _patients;
        public void AddPatient(Patient patient)
        {
            try
            {
                _patients.Add(patient);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in adding patient : {ex.Message}", ex);
            }
        }
        public void RemovePatient(Guid patientId)
        {
            try
            {
                var patinet = _patients.FirstOrDefault(p => p.PatientId == patientId);
                if (patinet != null)
                {
                    _patients.Remove(patinet);
                }
                else
                {
                    throw new Exception($"patient with Id {patientId} not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in removing patient : {ex.Message}", ex);
            }
        }
        public Patient? GetPatientByPatientId(Guid patientId)
        {
            try
            {
                return _patients.FirstOrDefault(p => p.PatientId == patientId);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting patient: {ex.Message}", ex);
            }
        }
        public List<Patient> GetAllPatient()
        {
            try
            {
                return _patients;
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting patients: {ex.Message}", ex);
            }
        }
        public void AddIssueToPatient(Guid patientId, string issue)
        {
            try
            {
                var patient = _patients.FirstOrDefault(patient => patient.PatientId == patientId);
                if(patient == null)
                {
                    throw new Exception($"Patient with id {patientId} not found.");
                }
                patient.AddToMedicalHistory(issue);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in adding patient : {ex.Message}", ex);
            }
        }
    }
}
