using System;
using System.Collections.Generic;

// Abstract Class: Patient
abstract class Patient {
    protected int patientId;
    protected string name;
    protected int age;

    // Constructor
    public Patient(int patientId, string name, int age) {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    // Abstract Method for Bill Calculation
    public abstract double CalculateBill();

    // Method to Display Patient Details
    public void GetPatientDetails() {
        Console.WriteLine("Patient ID: " + patientId + ", Name: " + name + ", Age: " + age);
    }
}

// Interface for Medical Record Management
interface IMedicalRecord {
    void AddRecord(string record);
    void ViewRecords();
}

// Concrete Class: InPatient (Implements IMedicalRecord)
class InPatient : Patient, IMedicalRecord {
    private double dailyCharge;
    private int daysAdmitted;
    private List<string> medicalRecords = new List<string>();

    public InPatient(int patientId, string name, int age, double dailyCharge, int daysAdmitted)
        : base(patientId, name, age) {
        this.dailyCharge = dailyCharge;
        this.daysAdmitted = daysAdmitted;
    }

    public override double CalculateBill() {
        return dailyCharge * daysAdmitted; // In-Patient Billing Calculation
    }

    public void AddRecord(string record) {
        medicalRecords.Add(record);
    }

    public void ViewRecords() {
        Console.WriteLine("Medical Records for InPatient:");
        foreach (string record in medicalRecords) {
            Console.WriteLine("- " + record);
        }
    }
}

// Concrete Class: OutPatient (Implements IMedicalRecord)
class OutPatient : Patient, IMedicalRecord {
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age) {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill() {
        return consultationFee; // Out-Patient Billing Calculation
    }

    public void AddRecord(string record) {
        medicalRecords.Add(record);
    }

    public void ViewRecords() {
        Console.WriteLine("Medical Records for OutPatient:");
        foreach (string record in medicalRecords) {
            Console.WriteLine("- " + record);
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Patient List
        List<Patient> patients = new List<Patient> {
            new InPatient(101, "John Doe", 45, 2000, 5),
            new OutPatient(102, "Alice Smith", 30, 500),
            new InPatient(103, "David Johnson", 60, 2500, 3)
        };

        // Adding Medical Records
        ((InPatient)patients[0]).AddRecord("Surgery completed, needs follow-up.");
        ((OutPatient)patients[1]).AddRecord("General check-up, no issues.");
        ((InPatient)patients[2]).AddRecord("Admitted for pneumonia treatment.");

        // Displaying Patient Details and Bills
        foreach (Patient p in patients) {
            p.GetPatientDetails();
            Console.WriteLine("Total Bill: " + p.CalculateBill());

            // Explicit Type Checking for Medical Records
            if (p is InPatient) {
                ((InPatient)p).ViewRecords();
            } else if (p is OutPatient) {
                ((OutPatient)p).ViewRecords();
            }

            Console.WriteLine();
        }
    }
}
