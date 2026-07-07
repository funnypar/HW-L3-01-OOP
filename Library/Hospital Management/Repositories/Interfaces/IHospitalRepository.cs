namespace Hospital_Management.Repositories.Interfaces
{
    public interface IHospitalRepository
    {
        void AdmitPatient(Guid patientId, int roomNumber);
        void DischargePatient(Guid patientId, int roomNumber);
    }
}