using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy {
    static void CopyFile(string source, string destination) {
        Stopwatch stopwatch = new Stopwatch();
        
        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedStream = new BufferedStream(sourceStream, 4096)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            stopwatch.Start();
            while ((bytesRead = bufferedStream.Read(buffer, 0, buffer.Length)) > 0) {
                destStream.Write(buffer, 0, bytesRead);
            }
            stopwatch.Stop();
        }

        Console.WriteLine("Buffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    static void Main() {
        CopyFile("largefile.dat", "copy.dat");
    }
}
