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
class CryptoDataSender
{
    private void SendData(NetworkStream strm, Employees.SerialEmployee emp)
    {
        IFormatter formatter = new BinaryFormatter();
        MemoryStream memstrm = new MemoryStream();
        Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes("Password", Encoding.Default.GetBytes("Any Salt Data..."));

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        tdes.Key = rfc.GetBytes(tdes.KeySize / 8);
        tdes.IV = rfc.GetBytes(tdes.BlockSize / 8);

        CryptoStream csw = new CryptoStream(memstrm, tdes.CreateEncryptor(), CryptoStreamMode.Write);
        formatter.Serialize(csw, emp);
        csw.FlushFinalBlock();
        byte[] data = memstrm.GetBuffer();
        int memsize = (int)memstrm.Length;
        byte[] size = BitConverter.GetBytes(memsize);
        strm.Write(size, 0, 4);
        strm.Write(data, 0, (int)memsize);
        strm.Flush();
        csw.Close();
        memstrm.Close();
    }
    public CryptoDataSender()
    {
        SerialEmployee emp1 = new SerialEmployee();
        SerialEmployee emp2 = new SerialEmployee();
        emp1.EmployeeID = 1;
        emp1.LastName = "Blum";
        emp1.FirstName = "Katie Jane";
        emp1.YearsService = 12;
        emp1.Salary = 35000.50;
        emp2.EmployeeID = 2;
        emp2.LastName = "Blum";
        emp2.FirstName = "Jessica";
        emp2.YearsService = 9;
        emp2.Salary = 23700.30;
        TcpClient client = new TcpClient("127.0.0.1", 9050);
        NetworkStream strm = client.GetStream();
        SendData(strm, emp1);
        SendData(strm, emp2);
        strm.Close();
        client.Close();
    }
    public static void Main()
    {
        CryptoDataSender cds = new CryptoDataSender();
    }
}