using Hospital_Management.Mock;
using Hospital_Management.Repositories;
using Hospital_Management.Repositories.Interfaces;
using Hospital_Management.Services;
using Hospital_Management.Services.Interfaces;

namespace Hospital_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MockData mockData = new MockData();

            IPatientRepository patientRepository = new PatientRepository(mockData);
            IDoctorRepository doctorRepository = new DoctorRepository(mockData);
            IRoomRepository roomRepository = new RoomRepository(mockData, patientRepository.GetAllPatient());
            IHospitalRepository hospitalRepository = new HospitalRepository(patientRepository, roomRepository);

            IPatientService patientService = new PatientService(patientRepository);
            IHospitalService hospitalService = new HospitalService(hospitalRepository, roomRepository, doctorRepository);

            Menu(patientService, hospitalService);
        }

        static void Menu(IPatientService patientService, IHospitalService hospitalService)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==========================================");
                Console.WriteLine("      HOSPITAL MANAGEMENT SYSTEM");
                Console.WriteLine("==========================================\n");
                Console.ResetColor();

                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Delete Patient");
                Console.WriteLine("3. Show All Patients");
                Console.WriteLine("4. Show Patient Details");
                Console.WriteLine("5. Add Medical Issue to Patient");
                Console.WriteLine("6. Assign Patient to Room");
                Console.WriteLine("7. Show All Rooms");
                Console.WriteLine("8. Show All Doctors");
                Console.WriteLine("0. Exit");

                Console.Write("\nChoose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== Add Patient ===\n");
                        patientService.AddPatient();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== Delete Patient ===\n");
                        patientService.DeletePatient();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== All Patients ===\n");
                        patientService.ShowAllPatients();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("=== Patient Details ===\n");
                        patientService.ShowPatientDetails();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("=== Add Medical Issue ===\n");
                        patientService.AddIssueToPatient();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("=== Assign Patient To Room ===\n");
                        hospitalService.AssignPatientToRoom();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("=== Rooms ===\n");
                        hospitalService.ShowRoomsDetails();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("=== Doctors ===\n");
                        hospitalService.ShowDoctors();
                        break;

                    case "0":
                        exit = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nThank you for using Hospital Management System.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid option!");
                        Console.ResetColor();
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}