using System;
using System.IO;

class ImageToByteArray {
    static void Main() {
        string inputImage = "input.jpg";
        string outputImage = "output.jpg";

        byte[] imageBytes = File.ReadAllBytes(inputImage);
        File.WriteAllBytes(outputImage, imageBytes);

        Console.WriteLine("Image copied successfully.");
    }
}
