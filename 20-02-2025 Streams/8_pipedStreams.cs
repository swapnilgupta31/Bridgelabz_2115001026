using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedCommunication {
    static void Main() {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle)) {
            Thread writerThread = new Thread(() => {
                using (StreamWriter writer = new StreamWriter(pipeServer)) {
                    writer.WriteLine("Hello from Writer Thread");
                }
            });

            Thread readerThread = new Thread(() => {
                using (StreamReader reader = new StreamReader(pipeClient)) {
                    Console.WriteLine("Received: " + reader.ReadLine());
                }
            });

            writerThread.Start();
            readerThread.Start();
            writerThread.Join();
            readerThread.Join();
        }
    }
}
