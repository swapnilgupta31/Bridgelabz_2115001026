using System;

// Node Class: Represents a Student Record
class Student {
    public int rollNumber;
    public string name;
    public int age;
    public string grade;
    public Student next;

    // Constructor
    public Student(int rollNumber, string name, int age, string grade) {
        this.rollNumber = rollNumber;
        this.name = name;
        this.age = age;
        this.grade = grade;
        this.next = null;
    }
}

// Singly Linked List Class
class StudentList {
    private Student head;

    // Add Student at Beginning
    public void AddAtBeginning(int rollNumber, string name, int age, string grade) {
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.next = head;
        head = newStudent;
    }

    // Add Student at End
    public void AddAtEnd(int rollNumber, string name, int age, string grade) {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null) {
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newStudent;
    }

    // Add Student at Specific Position (1-based index)
    public void AddAtPosition(int position, int rollNumber, string name, int age, string grade) {
        if (position < 1) {
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1) {
            AddAtBeginning(rollNumber, name, age, grade);
            return;
        }
        Student newStudent = new Student(rollNumber, name, age, grade);
        Student temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Position out of range");
            return;
        }
        newStudent.next = temp.next;
        temp.next = newStudent;
    }

    // Delete Student by Roll Number
    public void DeleteByRollNumber(int rollNumber) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.rollNumber == rollNumber) {
            head = head.next;
            return;
        }
        Student temp = head;
        while (temp.next != null && temp.next.rollNumber != rollNumber) {
            temp = temp.next;
        }
        if (temp.next == null) {
            Console.WriteLine("Student not found");
            return;
        }
        temp.next = temp.next.next;
    }

    // Search Student by Roll Number
    public void SearchByRollNumber(int rollNumber) {
        Student temp = head;
        while (temp != null) {
            if (temp.rollNumber == rollNumber) {
                Console.WriteLine("Roll No: " + temp.rollNumber + ", Name: " + temp.name + ", Age: " + temp.age + ", Grade: " + temp.grade);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found");
    }

    // Update Student's Grade
    public void UpdateGrade(int rollNumber, string newGrade) {
        Student temp = head;
        while (temp != null) {
            if (temp.rollNumber == rollNumber) {
                temp.grade = newGrade;
                Console.WriteLine("Grade updated for Roll No: " + rollNumber);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found");
    }

    // Display All Students
    public void DisplayAll() {
        if (head == null) {
            Console.WriteLine("No student records available");
            return;
        }
        Student temp = head;
        while (temp != null) {
            Console.WriteLine("Roll No: " + temp.rollNumber + ", Name: " + temp.name + ", Age: " + temp.age + ", Grade: " + temp.grade);
            temp = temp.next;
        }
    }
}

// Main Program
class Program {
    static void Main() {
        StudentList studentList = new StudentList();

        // Adding students
        studentList.AddAtBeginning(101, "Alice", 20, "A");
        studentList.AddAtEnd(102, "Bob", 21, "B");
        studentList.AddAtPosition(2, 103, "Charlie", 22, "C");

        // Display all students
        Console.WriteLine("All Student Records:");
        studentList.DisplayAll();

        // Search for a student
        Console.WriteLine("\nSearching for Roll No 102:");
        studentList.SearchByRollNumber(102);

        // Update grade
        Console.WriteLine("\nUpdating Grade for Roll No 103:");
        studentList.UpdateGrade(103, "A+");
        studentList.DisplayAll();

        // Delete a student
        Console.WriteLine("\nDeleting Roll No 101:");
        studentList.DeleteByRollNumber(101);
        studentList.DisplayAll();
    }
}
