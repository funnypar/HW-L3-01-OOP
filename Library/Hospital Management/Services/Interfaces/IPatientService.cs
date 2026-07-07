namespace Hospital_Management.Services.Interfaces
{
    public interface IPatientService
    {
        void AddPatient();
        void DeletePatient();
        void ShowAllPatients();
        void ShowPatientDetails();
        void AddIssueToPatient();
    }
}
