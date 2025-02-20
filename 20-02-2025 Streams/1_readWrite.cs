using System;
using System.IO;

class ReadWriteFile {
    static void Main() {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        if (!File.Exists(sourceFile)) {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        using (FileStream readStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream writeStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write)) {
            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0) {
                writeStream.Write(buffer, 0, bytesRead);
            }
        }

        Console.WriteLine("File copied successfully.");
    }
}
