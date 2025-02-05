using System;
using System.Collections.Generic;

class Course {
    public string CourseName { get; set; }
    private List<Student> students;
    private Professor professor;

    public Course(string name) {
        CourseName = name;
        students = new List<Student>();
    }

    public void AssignProfessor(Professor prof) {
        professor = prof;
        Console.WriteLine("Professor " + prof.ProfessorName + " assigned to " + CourseName);
    }

    public void EnrollStudent(Student student) {
        students.Add(student);
        Console.WriteLine(student.StudentName + " enrolled in " + CourseName);
    }

    public void ShowCourseDetails() {
        Console.WriteLine("Course: " + CourseName);
        if (professor != null) {
            Console.WriteLine("Taught by: " + professor.ProfessorName);
        }
        Console.WriteLine("Enrolled Students:");
        foreach (var student in students) {
            Console.WriteLine(" - " + student.StudentName);
        }
    }
}

class Student {
    public string StudentName { get; set; }

    public Student(string name) {
        StudentName = name;
    }
}

class Professor {
    public string ProfessorName { get; set; }

    public Professor(string name) {
        ProfessorName = name;
    }
}

class Program {
    static void Main() {
        // Creating Students
        Student student1 = new Student("John");
        Student student2 = new Student("Emma");

        // Creating Professor
        Professor professor = new Professor("Dr. Smith");

        // Creating Course
        Course course = new Course("Computer Science");

        // Assigning Professor
        course.AssignProfessor(professor);

        // Enrolling Students
        course.EnrollStudent(student1);
        course.EnrollStudent(student2);

        // Display Course Details
        course.ShowCourseDetails();
    }
}
