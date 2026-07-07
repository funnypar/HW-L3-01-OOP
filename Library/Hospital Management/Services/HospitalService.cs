using Hospital_Management.Repositories.Interfaces;
using Hospital_Management.Services.Interfaces;

namespace Hospital_Management.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _hospitalRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IDoctorRepository _doctorRepository;

        public HospitalService(IHospitalRepository hospitalRepository, IRoomRepository roomRepository, IDoctorRepository doctorRepository)
        {
            _hospitalRepository = hospitalRepository;
            _roomRepository = roomRepository;
            _doctorRepository = doctorRepository;
        }

        public void AssignPatientToRoom()
        {
            try
            {
                Console.Write("Enter Patient Id: ");
                if (!Guid.TryParse(Console.ReadLine(), out Guid patientId))
                {
                    Console.WriteLine("Invalid Patient Id format.");
                    return;
                }

                Console.Write("Enter Room Number: ");
                if (!int.TryParse(Console.ReadLine(), out int roomNumber))
                {
                    Console.WriteLine("Invalid Room Number.");
                    return;
                }

                _hospitalRepository.AdmitPatient(patientId, roomNumber);
                Console.WriteLine("Patient assigned to room successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void ShowRoomsDetails()
        {
            try
            {
                foreach (var room in _roomRepository.GetRooms())
                {
                    string patients = room.Patients.Count > 0
                        ? string.Join(", ",
                            room.Patients.Select(p => $"{p.Name} (ID: {p.PatientId})"))
                        : "No patients";

                    Console.WriteLine(
                        $"Room {room.RoomNumber} | Capacity: {room.Capacity} | Patients: {patients}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void ShowDoctors()
        {
            try
            {
                foreach (var doctor in _doctorRepository.GetAllDoctor())
                {
                    Console.WriteLine($"Doctor {doctor.Name} with doctor id : {doctor.DoctorId}."); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}