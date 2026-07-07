using Hospital_Management.Exceptions;

namespace Hospital_Management.Models
{
    public class Hospital
    {
        public Hospital(List<Room> rooms, List<Doctor> doctors) { 
            _doctors = doctors;
            _rooms = rooms;
        }

        private List<Doctor> _doctors;

        private List<Room> _rooms;
        public void AdmitPatient(Patient patient)
        {
            try
            {
                var freeRoom = _rooms.FirstOrDefault(room => (room.Capacity - room.Patients.Count) > 0);
                if (freeRoom != null)
                {
                    freeRoom.AssignPatient(patient);
                }
                else
                {
                    throw new RoomFullException("All rooms are full.");
                }
            }
            catch (Exception ex) {
                throw new Exception($"There was an error in admiting patient: {ex.Message}",ex);
            }
        }

        public void DischargePatient(Guid patientId)
        {
            try
            {
                var patientRoom = _rooms.FirstOrDefault(room => room.Patients.Any(patient => patient.PatientId == patientId));
                if (patientRoom != null)
                {
                    patientRoom.Patients.RemoveAll(patient => patient.PatientId == patientId);
                }
                else
                {
                    throw new Exception($"Patinet with Id : {patientId} not found.");
                }
            }
            catch (Exception ex) {
                throw new Exception($"There was an error in discharging patient : {ex.Message}",ex);
            }
        }
    }
}
