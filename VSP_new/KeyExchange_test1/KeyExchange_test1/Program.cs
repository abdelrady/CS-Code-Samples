using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace KeyExchange_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            RijndaelManaged myalg = new RijndaelManaged();
            myalg.GenerateKey();
            RSACryptoServiceProvider rsa=new RSACryptoServiceProvider();
            byte[] keyexchange=GetKeyExchange(myalg.Key,rsa.ExportParameters(false));
            Console.Write("Symmetric Key: ");
            foreach (byte p in myalg.Key)
            {
                Console.Write("{0:x2}-", p);
            }
            Console.WriteLine();
            Console.Write("Key Exchange: ");
            foreach (byte p in keyexchange)
            {
                Console.Write("{0:x2}-", p);
            }
            Console.WriteLine();
            CspParameters csp=new CspParameters();
            csp.KeyContainerName=rsa.CspKeyContainerInfo.KeyContainerName;
            byte[] key = GetKey(keyexchange, csp);
            Console.Write("Symmetric Key: ");
            foreach (byte p in key)
            {
                Console.Write("{0:x2}-", p);
            }
        }

        private static byte[] GetKey(byte[] keyexchange, CspParameters csp)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
            RSAOAEPKeyExchangeDeformatter deformatter = new RSAOAEPKeyExchangeDeformatter();
            deformatter.SetKey(rsa);
            return deformatter.DecryptKeyExchange(keyexchange);
        }

        private static byte[] GetKeyExchange(byte[] key, RSAParameters rSAParameters)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rSAParameters);

            RSAOAEPKeyExchangeFormatter formatter = new RSAOAEPKeyExchangeFormatter();
            formatter.SetKey(rsa);
            return formatter.CreateKeyExchange(key);
        }
    }
}
