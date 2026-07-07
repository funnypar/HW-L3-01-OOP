using Hospital_Management.Exceptions;

namespace Hospital_Management.Models
{
    public class Room
    {
        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; } = [];
        public void AssignPatient(Patient patient)
        {
            try
            {
                if (Patients.Count < Capacity)
                {
                    Patients.Add(patient);
                }
                else
                {
                    throw new RoomFullException($"Room {RoomNumber} is full. Capacity: {Capacity}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"There is an error in assigning a patient: {ex.Message}", ex);
            }
        }
    }
}
