using Hospital_Management.Models;

namespace Hospital_Management.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        void AssignPatient(Room room, Patient patient);
        void DischargePatient(Room room, Patient patient);
        List<Room> GetRooms();
        Room GetRoom(int roomNumber);
    }
}