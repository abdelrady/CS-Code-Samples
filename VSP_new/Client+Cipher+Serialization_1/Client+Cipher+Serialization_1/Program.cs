using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security;
using System.Security.Cryptography;
using System.Text;

[Serializable]
class SerialEmployee
{
    public int EmployeeID; public string LastName, FirstName;
    public int YearsService;
    public double Salary;
}
class CryptoDataRcvr
{
    private SerialEmployee RecvData(NetworkStream strm)
    {
        MemoryStream memstrm = new MemoryStream();
        byte[] Key = {0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09,
          0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16};
        byte[] IV = {0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09,
          0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16};
        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        CryptoStream csw = new CryptoStream(memstrm, tdes.CreateDecryptor(Key, IV),
                  CryptoStreamMode.Write);
        byte[] data = new byte[2048];
        int recv = strm.Read(data, 0, 4);
        int size = BitConverter.ToInt32(data, 0);
        int offset = 0;
        while (size > 0)
        {
            recv = strm.Read(data, 0, size);
            csw.Write(data, offset, recv);
            offset += recv;
            size -= recv;
        }
        csw.FlushFinalBlock();
        IFormatter formatter = new SoapFormatter();
        memstrm.Position = 0;
        SerialEmployee emp = (SerialEmployee)formatter.Deserialize(memstrm);
        memstrm.Close();
        return emp;
    }
    public CryptoDataRcvr()
    {
        TcpListener server = new TcpListener(9050);
        server.Start();
        Console.WriteLine("Waiting for a client...");
        TcpClient client = server.AcceptTcpClient();
        NetworkStream strm = client.GetStream();
        SerialEmployee emp1 = RecvData(strm);
        Console.WriteLine("emp1.EmployeeID = {0}", emp1.EmployeeID);
        Console.WriteLine("emp1.LastName = {0}", emp1.LastName);
        Console.WriteLine("emp1.FirstName = {0}", emp1.FirstName);
        Console.WriteLine("emp1.YearsService = {0}", emp1.YearsService);
        Console.WriteLine("emp1.Salary = {0}\n", emp1.Salary);
        SerialEmployee emp2 = RecvData(strm);
        Console.WriteLine("emp2.EmployeeID = {0}", emp2.EmployeeID);
        Console.WriteLine("emp2.LastName = {0}", emp2.LastName);
        Console.WriteLine("emp2.FirstName = {0}", emp2.FirstName);
        Console.WriteLine("emp2.YearsService = {0}", emp2.YearsService);
        Console.WriteLine("emp2.Salary = {0}", emp2.Salary);
        strm.Close();
        server.Stop();
    }
    public static void Main()
    {
        CryptoDataRcvr cdr = new CryptoDataRcvr();
    }
}