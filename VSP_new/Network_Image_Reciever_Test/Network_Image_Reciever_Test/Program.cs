/*using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
 class UdpClientMultiRecv
{
     public static void Main()
     {
         UdpClient sock = new UdpClient(9050); // «· ’‰  ⁄·Ï —ﬁ„ «·»Ê—  Â–«
         sock.JoinMulticastGroup(IPAddress.Parse("224.100.0.1"), 50);

         IPEndPoint iep = new IPEndPoint(IPAddress.Any, 0);
         byte[] data = sock.Receive(ref iep);

         // «· ÕÊÌ· ≈·Ï «”ﬂÌ ﬂÊœ À„ ÿ»«⁄… «·—”«·… ⁄·Ï «·‘«‘…
         string stringData = Encoding.ASCII.GetString(data, 0, data.Length);
         Console.WriteLine("received: {0} from: {1}", stringData, iep.ToString());
         sock.Close();
     }
}  */

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MultiSend
{
    public static void Main()
    {
        Socket server = new Socket(AddressFamily.InterNetwork,
                SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint iep = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 9050);
        byte[] data = Encoding.ASCII.GetBytes("This is a test message");
        server.SendTo(data, iep);
        byte[] d2 = new byte[1500];
        EndPoint ep = (EndPoint)new IPEndPoint(IPAddress.Any, 0);
        server.ReceiveFrom(d2, ref ep);
        Console.WriteLine("Recieved From: " + ((IPEndPoint)ep).ToString() + " , and the Message Is: " + Encoding.Default.GetString(d2));
        server.Close();
    }
}