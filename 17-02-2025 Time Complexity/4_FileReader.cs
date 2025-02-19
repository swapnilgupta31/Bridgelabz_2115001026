using System;
using System.Diagnostics;
using System.IO;

class FileReadPerformance {
    static void Main() {
        string filePath = "largefile.txt"; // Ensure this file exists (500MB for best results)

        Stopwatch stopwatch = new Stopwatch();

        // Using StreamReader (Text-based, line by line)
        stopwatch.Start();
        using (StreamReader reader = new StreamReader(filePath)) {
            while (reader.ReadLine() != null) { }
        }
        stopwatch.Stop();
        Console.WriteLine("StreamReader Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Using FileStream (Byte-based, more efficient)
        stopwatch.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read)) {
            byte[] buffer = new byte[8192]; // 8KB buffer
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        stopwatch.Stop();
        Console.WriteLine("FileStream Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
