using Hospital_Management.Mock;
using Hospital_Management.Models;
using Hospital_Management.Repositories.Interfaces;

namespace Hospital_Management.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private List<Room> _rooms;

        public RoomRepository(MockData mockData, List<Patient> patients)
        {
            _rooms = mockData.MockRoomsWithPatients(patients);
        }

        public void AssignPatient(Room room, Patient patient)
        {
            try
            {
                room.AssignPatient(patient);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in assigning patient : {ex.Message}", ex);
            }
        }

        public void DischargePatient(Room room, Patient patient)
        {
            try
            {
                var patientInRoom = room.Patients.FirstOrDefault(p => p.PatientId == patient.PatientId);
                if (patientInRoom == null)
                {
                    throw new Exception($"Patient {patient.PatientId} is not assigned to room {room.RoomNumber}.");
                }

                room.Patients.Remove(patientInRoom);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in discharging patient : {ex.Message}", ex);
            }
        }

        public List<Room> GetRooms()
        {
            try
            {
                return _rooms;
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting rooms : {ex.Message}", ex);
            }
        }

        public Room GetRoom(int roomNumber)
        {
            try
            {
                var room = _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
                if (room == null) { throw new Exception($"No room with id {roomNumber} found."); }
                return room;
            }
            catch (Exception ex)
            {
                throw new Exception($"There was an error in getting room : {ex.Message}", ex);
            }
        }
    }
}