using System;

class Patient {
    static string hospitalName = "City Hospital"; // Static variable shared among all patients
    static int totalPatients = 0; // Static variable to count total patients
    public readonly int patientID; // Readonly variable for unique patient ID
    public string name;
    public int age;
    public string ailment;

    // Constructor to initialize patient details
    public Patient(int patientID, string name, int age, string ailment) {
        this.patientID = patientID; // 'this' differentiates instance and parameter variables
        this.name = name;
        this.age = age;
        this.ailment = ailment;

        totalPatients++; // Increment patient count
    }

    // Static method to get total patients
    public static void GetTotalPatients() {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    // Method to display patient details
    public void DisplayPatientDetails() {
        if (this is Patient) { // 'is' operator to validate type
            Console.WriteLine("\nHospital: " + hospitalName);
            Console.WriteLine("Patient ID: " + patientID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Ailment: " + ailment);
        } else {
            Console.WriteLine("Invalid Patient");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating patient objects
        Patient patient1 = new Patient(101, "John Doe", 45, "Flu");
        Patient patient2 = new Patient(102, "Alice Smith", 34, "Cold");

        // Displaying patient details
        patient1.DisplayPatientDetails();
        patient2.DisplayPatientDetails();

        // Displaying total patients
        Patient.GetTotalPatients();
    }
}
