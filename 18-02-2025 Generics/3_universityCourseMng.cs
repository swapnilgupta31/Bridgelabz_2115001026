
using System;
using System.Collections.Generic;

// Abstract class for CourseType
abstract class CourseType {
    public string CourseName { get; set; }
}

// Exam-based course
class ExamCourse : CourseType {
    public ExamCourse(string name) { CourseName = name; }
}

// Assignment-based course
class AssignmentCourse : CourseType {
    public AssignmentCourse(string name) { CourseName = name; }
}

// Generic Course class
class Course<T> where T : CourseType {
    private List<T> courses = new List<T>();

    public void AddCourse(T course) {
        courses.Add(course);
    }

    public void DisplayCourses() {
        foreach (T course in courses) {
            Console.WriteLine("Course: " + course.CourseName);
        }
    }
}

// Test the university system
class Program {
    static void Main() {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        examCourses.AddCourse(new ExamCourse("Math 101"));
        examCourses.AddCourse(new ExamCourse("Physics 201"));

        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
        assignmentCourses.AddCourse(new AssignmentCourse("History Paper"));
        assignmentCourses.AddCourse(new AssignmentCourse("Research Thesis"));

        Console.WriteLine("Exam Courses:");
        examCourses.DisplayCourses();

        Console.WriteLine("\nAssignment Courses:");
        assignmentCourses.DisplayCourses();
    }
}



	
