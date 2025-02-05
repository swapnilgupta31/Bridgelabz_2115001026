using System;
using System.Collections.Generic;

class Course {
    public string CourseName { get; set; }
    private List<Student> enrolledStudents;

    public Course(string courseName) {
        CourseName = courseName;
        enrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student) {
        enrolledStudents.Add(student);
    }

    public void DisplayStudents() {
        Console.WriteLine("Course: " + CourseName);
        foreach (var student in enrolledStudents) {
            Console.WriteLine("  Enrolled Student: " + student.StudentName);
        }
    }
}

class Student {
    public string StudentName { get; set; }
    private List<Course> enrolledCourses;

    public Student(string studentName) {
        StudentName = studentName;
        enrolledCourses = new List<Course>();
    }

    public void EnrollInCourse(Course course) {
        enrolledCourses.Add(course);
        course.EnrollStudent(this); // Student bhi course me add ho jaye
    }

    public void DisplayCourses() {
        Console.WriteLine("Student: " + StudentName);
        foreach (var course in enrolledCourses) {
            Console.WriteLine("  Enrolled in Course: " + course.CourseName);
        }
    }
}

class School {
    public string SchoolName { get; set; }
    private List<Student> students;

    public School(string schoolName) {
        SchoolName = schoolName;
        students = new List<Student>();
    }

    public void AddStudent(Student student) {
        students.Add(student);
    }

    public void DisplayStudents() {
        Console.WriteLine("School: " + SchoolName);
        foreach (var student in students) {
            Console.WriteLine("  Student: " + student.StudentName);
        }
    }
}

class Program {
    static void Main() {
        // Creating School
        School mySchool = new School("Greenwood High");

        // Creating Students
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");

        // Creating Courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Enrolling Students in Courses
        student1.EnrollInCourse(math);
        student1.EnrollInCourse(science);
        student2.EnrollInCourse(math);

        // Adding Students to School (Aggregation)
        mySchool.AddStudent(student1);
        mySchool.AddStudent(student2);

        // Displaying School and its Students
        mySchool.DisplayStudents();
        Console.WriteLine();

        // Displaying Students and their Courses
        student1.DisplayCourses();
        student2.DisplayCourses();
        Console.WriteLine();

        // Displaying Courses and their Enrolled Students
        math.DisplayStudents();
        science.DisplayStudents();
    }
}
