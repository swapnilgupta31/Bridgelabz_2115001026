using System;
using System.Collections.Generic;

class Patient {
    public string PatientName { get; set; }

    public Patient(string name) {
        PatientName = name;
    }

    public void DisplayPatient() {
        Console.WriteLine("Patient: " + PatientName);
    }
}

class Doctor {
    public string DoctorName { get; set; }
    private List<Patient> patients; // Association with Patients

    public Doctor(string name) {
        DoctorName = name;
        patients = new List<Patient>();
    }

    public void Consult(Patient patient) {
        patients.Add(patient);
        Console.WriteLine(DoctorName + " is consulting " + patient.PatientName);
    }

    public void ShowPatients() {
        Console.WriteLine("Doctor " + DoctorName + " has consulted:");
        foreach (var patient in patients) {
            patient.DisplayPatient();
        }
    }
}

class Hospital {
    public string HospitalName { get; set; }
    private List<Doctor> doctors;
    private List<Patient> patients;

    public Hospital(string name) {
        HospitalName = name;
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor) {
        doctors.Add(doctor);
    }

    public void AddPatient(Patient patient) {
        patients.Add(patient);
    }

    public void DisplayDetails() {
        Console.WriteLine("Hospital: " + HospitalName);
        Console.WriteLine("Doctors:");
        foreach (var doctor in doctors) {
            Console.WriteLine(" - " + doctor.DoctorName);
        }
        Console.WriteLine("Patients:");
        foreach (var patient in patients) {
            Console.WriteLine(" - " + patient.PatientName);
        }
    }
}

class Program {
    static void Main() {
        // Creating Hospital
        Hospital myHospital = new Hospital("City Hospital");

        // Creating Doctors
        Doctor doctor1 = new Doctor("Dr. Smith");
        Doctor doctor2 = new Doctor("Dr. Johnson");

        // Creating Patients
        Patient patient1 = new Patient("Alice");
        Patient patient2 = new Patient("Bob");

        // Adding Doctors & Patients to Hospital
        myHospital.AddDoctor(doctor1);
        myHospital.AddDoctor(doctor2);
        myHospital.AddPatient(patient1);
        myHospital.AddPatient(patient2);

        // Consultations (Association & Communication)
        doctor1.Consult(patient1); // Dr. Smith consults Alice
        doctor1.Consult(patient2); // Dr. Smith consults Bob
        doctor2.Consult(patient2); // Dr. Johnson consults Bob

        // Displaying Hospital Details
        myHospital.DisplayDetails();

        // Displaying Doctor-Patient Consultations
        doctor1.ShowPatients();
        doctor2.ShowPatients();
    }
}
