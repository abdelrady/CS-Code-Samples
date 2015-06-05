using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using Employees;
using System.Runtime.Serialization.Formatters.Binary;
class CryptoDataRcvr
{
    private Employees.SerialEmployee RecvData(NetworkStream strm)
    {
        MemoryStream memstrm = new MemoryStream();
        Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes("Password", Encoding.Default.GetBytes("Any Salt Data..."));

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        tdes.Key = rfc.GetBytes(tdes.KeySize / 8);
        tdes.IV = rfc.GetBytes(tdes.BlockSize / 8);

        CryptoStream csw = new CryptoStream(memstrm, tdes.CreateDecryptor(),
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
        memstrm.Position = 0;

        IFormatter formatter = new BinaryFormatter();
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
        emp1.ShowResult(emp1);
        SerialEmployee emp2 = RecvData(strm);
        emp2.ShowResult(emp2);
        /*Console.WriteLine("emp2.EmployeeID = {0}", emp2.EmployeeID);
        Console.WriteLine("emp2.LastName = {0}", emp2.LastName);
        Console.WriteLine("emp2.FirstName = {0}", emp2.FirstName);
        Console.WriteLine("emp2.YearsService = {0}", emp2.YearsService);
        Console.WriteLine("emp2.Salary = {0}", emp2.Salary);*/
        strm.Close();
        server.Stop();
    }
    public static void Main()
    {
        CryptoDataRcvr cdr = new CryptoDataRcvr();
    }
}