using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Threading;
public class VerySimpleWebServer {
  public static void Main(String[] args) {
      
    TcpListener server = new TcpListener(/*int.Parse(args[0])*/ 8080);
    server.Start();
    TcpClient client = server.AcceptTcpClient();
    NetworkStream stream = client.GetStream();
    StreamReader reader = new StreamReader(stream);
    StreamWriter writer;
    stream.Close();
    //Thread.Sleep(Timeout.Infinite);
    while (true)
    {
        String s = reader.ReadLine();                      // Note 1
        String[] strings = s.Split();                      // Note 2
        
        if (strings[0] != "GET")
        {                         // Note 3
            writer = new StreamWriter(stream);
            writer.WriteLine
                       ("HTTP/1.0 501 Not Implemented");
            writer.WriteLine();
        }
        else
        {
            Console.WriteLine(strings[1]);
            String filename = strings[1];                   // Note 4
            while (reader.ReadLine() != "") ;                 // Note 5
            writer = new StreamWriter(stream);              // Note 6
            string response = "HTTP/1.0 200 OK" + "\r\nContent-type: image/gif\r\n\r\n";
            //StreamReader file = new StreamReader(filename.Remove(0,1));
            byte[] z = File.ReadAllBytes("e:\\" + filename.Remove(0, 1));//file.ReadToEnd();                    // Note 9
            byte[] y = Encoding.Default.GetBytes(response);
            writer.BaseStream.Write(y, 0, y.Length);
            writer.BaseStream.Write(z, 0, z.Length);
            writer.Flush();
            
        }
    }
    writer.Close();
    //file.Close();
    client.Close();
    stream.Close();
    reader.Close();
    //writer.Close();
    server.Stop();
}
}
