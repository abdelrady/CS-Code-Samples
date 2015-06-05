using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Security_Test_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SymmetricAlgorithm sym = new RijndaelManaged();
            //sym.GenerateKey();
            //sym.GenerateIV();
            Rfc2898DeriveBytes rfc=new Rfc2898DeriveBytes("mypassword",Encoding.Default.GetBytes("My Salt..."));
            sym.Key = rfc.GetBytes(sym.KeySize / 8);
            sym.IV = rfc.GetBytes(sym.BlockSize / 8);

            BinaryWriter bw = new BinaryWriter(File.OpenWrite("keysSym.txt"));
            bw.Write(Encoding.Default.GetString( sym.Key));
            bw.Write(Encoding.Default.GetString(sym.IV));
            Console.WriteLine(sym.Key.Length.ToString());
            Console.WriteLine(sym.IV.Length.ToString());
            bw.Close();
            CryptoStream cryp = new CryptoStream(new FileStream("testsym.txt", FileMode.Create, FileAccess.Write), sym.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cryp);
            sw.Write("Symetric algo..");
            sw.Flush();
            sw.Close();



            SymmetricAlgorithm sym2 = new RijndaelManaged();
            BinaryReader br = new BinaryReader(File.OpenRead("keysSym.txt"));
            sym2.Key = sym.Key;
            sym2.IV = sym.IV;
            br.Close();
            
            CryptoStream cryp2 = new CryptoStream(new FileStream("testsym.txt", FileMode.Open, FileAccess.Read), sym2.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cryp2);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            */
            /*
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSACryptoServiceProvider rsa2 = new RSACryptoServiceProvider();
            File.WriteAllText("keys.txt", rsa.ToXmlString(true));
            
            byte[] byt= rsa.Encrypt(Encoding.Default.GetBytes("Welcome To Asymetric Cryptography...."), true);

            test(byt);*/
            /*
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSACryptoServiceProvider rsa2 = new RSACryptoServiceProvider();

            CspParameters csp = new CspParameters();
            csp.KeyContainerName = rsa.CspKeyContainerInfo.KeyContainerName;
            */
            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            Encoding ui=Encoding.Default;
            byte[] data = ui.GetBytes("Hello World.......");

            byte[] signedData = dsa.SignData(data);
            signedData[0] = 15;
            Console.WriteLine(dsa.VerifyData(data, signedData));

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            HashAlgorithm hash = HashAlgorithm.Create("SHA1");

            signedData = rsa.SignData(data, hash);
            Console.WriteLine(rsa.VerifyData(data,hash,signedData));


        }

        public byte[] eXchange(byte[] sessionKey,RSAParameters PublicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(PublicKey);

            RSAOAEPKeyExchangeFormatter formater = new RSAOAEPKeyExchangeFormatter();
            formater.SetKey(rsa);
            return formater.CreateKeyExchange(sessionKey);
        }
        public byte[] deEXchange(byte[] encryptedSessionKey, CspParameters PrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(PrivateKey);
            RSAOAEPKeyExchangeDeformatter deformatter = new RSAOAEPKeyExchangeDeformatter();
            deformatter.SetKey(rsa);
            return deformatter.DecryptKeyExchange(encryptedSessionKey);
        }
        static void test(byte[] testData)
        {
            RSACryptoServiceProvider rsa2 = new RSACryptoServiceProvider();
            rsa2.FromXmlString(File.ReadAllText("keys.txt"));
            byte[] byt = rsa2.Decrypt(testData, true);

            Console.WriteLine(Encoding.Default.GetString(byt));
        }
    }
}
