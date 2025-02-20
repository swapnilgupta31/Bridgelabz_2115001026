using System;
using System.IO;

class BinaryData {
    static void Main() {
        string filePath = "students.dat";

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create))) {
            writer.Write(1);
            writer.Write("Alice");
            writer.Write(3.9);
        }

        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open))) {
            int roll = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine("Student: " + name + " (Roll: " + roll + ") - GPA: " + gpa);
        }
    }
}
