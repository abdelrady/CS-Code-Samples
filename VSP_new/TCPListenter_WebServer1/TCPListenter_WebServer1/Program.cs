using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
public class VerySimpleWebServer {
  public static void Main(String[] args) {
    TcpListener server = new TcpListener(int.Parse(args[0]));
    server.Start();
    TcpClient client = server.AcceptTcpClient();
    NetworkStream stream = client.GetStream();
    StreamReader reader = new StreamReader(stream);
    String s = reader.ReadLine();                      // Note 1
    String[] strings = s.Split();                      // Note 2
    StreamWriter writer;
    if (strings[0] != "GET") {                         // Note 3
      writer = new StreamWriter(stream);
      writer.WriteLine
                 ("HTTP/1.0 501 Not Implemented");
      writer.WriteLine();
    } else {
        Console.WriteLine(strings[1]);
        String filename = strings[1];                   // Note 4
        while (reader.ReadLine() != "") ;                 // Note 5
        writer = new StreamWriter(stream);              // Note 6
        writer.WriteLine("HTTP/1.0 200 OK");            // Note 7
        writer.WriteLine("Content-type: text/plain");
        writer.WriteLine();                             // Note 8
        StreamReader file = new StreamReader(filename);
        String z = file.ReadToEnd();                    // Note 9
        writer.WriteLine(z);
        writer.Flush();
        writer.Close();
        file.Close();
    }
    client.Close();
    stream.Close();
    reader.Close();
    writer.Close();
    server.Stop();
}
}
