using System;
using System.IO;

class UpperToLower {
    static void Main() {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                writer.WriteLine(line.ToLower());
            }
        }

        Console.WriteLine("Conversion complete.");
    }
}
