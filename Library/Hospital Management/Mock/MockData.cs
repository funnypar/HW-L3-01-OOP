using Hospital_Management.Models;

namespace Hospital_Management.Mock
{
    public class MockData
    {
        public List<Patient> MockPatients()
        {
            return new List<Patient>
            {
                new Patient("John Smith", 32, 1000000001)
                {
                    MedicalHistory = new List<string> { "Flu", "Seasonal Allergy" }
                },

                new Patient("Emily Johnson", 28, 1000000002)
                {
                    MedicalHistory = new List<string> { "Asthma" }
                },

                new Patient("Michael Brown", 45, 1000000003)
                {
                    MedicalHistory = new List<string> { "Diabetes Type 2", "High Blood Pressure" }
                },

                new Patient("Sophia Davis", 22, 1000000004)
                {
                    MedicalHistory = new List<string> { "Broken Arm" }
                },

                new Patient("Daniel Wilson", 51, 1000000005)
                {
                    MedicalHistory = new List<string> { "Heart Disease" }
                },

                new Patient("Olivia Miller", 34, 1000000006)
                {
                    MedicalHistory = new List<string> { "Migraine" }
                },

                new Patient("James Moore", 40, 1000000007)
                {
                    MedicalHistory = new List<string> { "Kidney Stones" }
                },

                new Patient("Emma Taylor", 26, 1000000008)
                {
                    MedicalHistory = new List<string> { "Anemia" }
                },

                new Patient("William Anderson", 60, 1000000009)
                {
                    MedicalHistory = new List<string> { "Arthritis", "High Cholesterol" }
                },

                new Patient("Ava Thomas", 19, 1000000010)
                {
                    MedicalHistory = new List<string> { "Chickenpox" }
                },

                new Patient("Benjamin Jackson", 37, 1000000011)
                {
                    MedicalHistory = new List<string> { "Back Pain" }
                },

                new Patient("Mia White", 30, 1000000012)
                {
                    MedicalHistory = new List<string> { "Thyroid Disorder" }
                },

                new Patient("Lucas Harris", 42, 1000000013)
                {
                    MedicalHistory = new List<string> { "Pneumonia" }
                },

                new Patient("Charlotte Martin", 27, 1000000014)
                {
                    MedicalHistory = new List<string> { "Anxiety" }
                },

                new Patient("Henry Thompson", 55, 1000000015)
                {
                    MedicalHistory = new List<string> { "Stroke", "Hypertension" }
                },

                new Patient("Amelia Garcia", 31, 1000000016)
                {
                    MedicalHistory = new List<string> { "Sinus Infection" }
                },

                new Patient("Alexander Martinez", 48, 1000000017)
                {
                    MedicalHistory = new List<string> { "Ulcer" }
                },

                new Patient("Evelyn Robinson", 24, 1000000018)
                {
                    MedicalHistory = new List<string> { "Vitamin D Deficiency" }
                },

                new Patient("Matthew Clark", 39, 1000000019)
                {
                    MedicalHistory = new List<string> { "COVID-19", "Bronchitis" }
                },

                new Patient("Harper Lewis", 29, 1000000020)
                {
                    MedicalHistory = new List<string> { "Eczema" }
                }
            };
        }
        public List<Doctor> MockDoctors()
        {
            return new List<Doctor>
            {
                new Doctor(
                    "Dr. Sarah Johnson",
                    45,
                    2000000001,
                    "Cardiology"
                ),
                new Doctor(
                    "Dr. Michael Brown",
                    52,
                    2000000002,
                    "Neurology"
                ),
                new Doctor(
                    "Dr. Emily Davis",
                    38,
                    2000000003,
                    "Pediatrics"
                ),
                new Doctor(
                    "Dr. David Wilson",
                    49,
                    2000000004,
                    "Orthopedics"
                ),
                new Doctor(
                    "Dr. Olivia Taylor",
                    41,
                    2000000005,
                    "Dermatology"
                )
            };
        }
       
        public List<Room> MockRoomsWithPatients(List<Patient> patients)
        {
            var rooms = new List<Room>
            {
                new Room(101, 1),
                new Room(102, 2),
                new Room(103, 2),
                new Room(104, 3),
                new Room(105, 4)
            };

            rooms[0].AssignPatient(patients[0]);

            rooms[1].AssignPatient(patients[1]);
            rooms[1].AssignPatient(patients[2]);

            rooms[2].AssignPatient(patients[3]);

            rooms[3].AssignPatient(patients[4]);
            rooms[3].AssignPatient(patients[5]);

            rooms[4].AssignPatient(patients[6]);
            rooms[4].AssignPatient(patients[7]);
            rooms[4].AssignPatient(patients[8]);

            return rooms;
        }
    }
}