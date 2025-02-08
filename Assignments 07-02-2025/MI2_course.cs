using System;

// Base class: Course
class Course {
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in weeks

    public virtual void DisplayInfo() {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " weeks");
    }
}

// Subclass: OnlineCourse (inherits Course)
class OnlineCourse : Course {
    public string Platform { get; set; }  // E.g., Udemy, Coursera
    public bool IsRecorded { get; set; }  // True if pre-recorded, False if live

    public override void DisplayInfo() {
        base.DisplayInfo(); // Call base class method
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

// Subclass: PaidOnlineCourse (inherits OnlineCourse)
class PaidOnlineCourse : OnlineCourse {
    public double Fee { get; set; }   // Course fee
    public double Discount { get; set; } // Discount percentage

    public override void DisplayInfo() {
        base.DisplayInfo(); // Call base class method
        Console.WriteLine("Course Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
        double finalPrice = Fee - (Fee * Discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);
    }
}

// Main program
class Program {
    public static void Main(string[] args) {
        // Creating a Paid Online Course object
        PaidOnlineCourse course1 = new PaidOnlineCourse();
        course1.CourseName = "C# for Beginners";
        course1.Duration = 6;
        course1.Platform = "Udemy";
        course1.IsRecorded = true;
        course1.Fee = 100;
        course1.Discount = 20;

        // Displaying course details
        course1.DisplayInfo();
    }
}
