using Hospital_Management.Repositories.Interfaces;

namespace Hospital_Management.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private IPatientRepository _patientRepository;
        private IRoomRepository _roomRepository;

        public HospitalRepository(IPatientRepository patientRepository, IRoomRepository roomRepository)
        {
            _patientRepository = patientRepository;
            _roomRepository = roomRepository;
        }

        public void AdmitPatient(Guid patientId, int roomNumber)
        {
            try
            {
                var patient = _patientRepository.GetPatientByPatientId(patientId);
                if (patient == null)
                    throw new Exception($"Patient with id {patientId} not found.");

                var room = _roomRepository.GetRoom(roomNumber);

                _roomRepository.AssignPatient(room, patient);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in admitting patient : {ex.Message}", ex);
            }
        }

        public void DischargePatient(Guid patientId, int roomNumber)
        {
            try
            {
                var patient = _patientRepository.GetPatientByPatientId(patientId);
                if (patient == null)
                    throw new Exception($"Patient with id {patientId} not found.");

                var room = _roomRepository.GetRoom(roomNumber);

                _roomRepository.DischargePatient(room, patient);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in discharging patient : {ex.Message}", ex);
            }
        }
    }
}