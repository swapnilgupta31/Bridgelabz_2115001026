
using System;
using System.Collections.Generic;

// Abstract class for Job Roles
abstract class JobRole {
    public string RoleName { get; set; }
}

// Software Engineer Role
class SoftwareEngineer : JobRole {
    public SoftwareEngineer() { RoleName = "Software Engineer"; }
}

// Data Scientist Role
class DataScientist : JobRole {
    public DataScientist() { RoleName = "Data Scientist"; }
}

// Generic Resume class
class Resume<T> where T : JobRole {
    public string CandidateName { get; set; }
    public T Role { get; set; }

    public Resume(string name, T role) {
        CandidateName = name;
        Role = role;
    }

    public void DisplayResume() {
        Console.WriteLine("Candidate: " + CandidateName + ", Applying for: " + Role.RoleName);
    }
}

// Test the resume screening system
class Program {
    static void Main() {
        Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>("Alice", new SoftwareEngineer());
        Resume<DataScientist> dsResume = new Resume<DataScientist>("Bob", new DataScientist());

        Console.WriteLine("Resume Screening:");
        seResume.DisplayResume();
        dsResume.DisplayResume();
    }
}



