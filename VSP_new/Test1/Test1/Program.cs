using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;

namespace Test1
{
    [Serializable]
    class test : IDeserializationCallback
    {
        int count, price;
        [NonSerialized]int total;
        public test(int a,int b)
        {
            count = a; price = b;
            total = a * b;
        }
        public void show()
        {
            Console.WriteLine("Count: " + count + " Price: " + price + " total: " + total);
        }
        void IDeserializationCallback.OnDeserialization(object sender)
        {
            total = price * count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BinaryFormatter x = new BinaryFormatter();
            List<test> array = new List<test>();
            array.Add(new test(10, 3));
            array.Add(new test(5, 3));
            array.Add(new test(1, 3));
            array.Add(new test(2, 2));
            array.Add(new test(10, 1));
            //test obj = new test(21, 3);
            MemoryStream ms = new MemoryStream();
            //Stream s=File.OpenWrite("ser.txt");
            x.Serialize(ms, array);
            ms.Flush();
            ms.Position = 0;
            //byte[] data = ms.ToArray();
            //ms.Close();
            List<test> array2 = x.Deserialize( ms) as List<test>;/*new MemoryStream(data)*/
            //obj2.show();*/


            AppDomain app = AppDomain.CreateDomain("My Domain");
            app.SetData("key", (object)"value");

            getdata();

            CrossAppDomainDelegate css = new CrossAppDomainDelegate(getdata);
            app.DoCallBack(css);
            /*foreach (test t in array2)
            {
                t.show();
            }*/
            
            /*
            //FileStream fs = new FileStream("test.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter("test1.txt"))
            {
                sw.Write("h");
            }

            using (StreamWriter sw = new StreamWriter("test2.txt",false, Encoding.UTF8))
            {
                sw.Write("hh");
            }

            using (StreamWriter sw = new StreamWriter("test3.txt", false, Encoding.UTF32))
            {
                sw.Write("h");
            }

            using (StreamWriter sw = new StreamWriter("test4.txt", false, Encoding.Unicode))
            {
                sw.Write("h");
            }
            using (StreamWriter sw = new StreamWriter("test5.txt", false, Encoding.BigEndianUnicode))
            {
                sw.Write("h");
            }

            for (int i = 1; i < 6; i++)
            {
                using (FileStream fs = new FileStream("test" + i + ".txt", FileMode.Open))
                {
                    Console.WriteLine("\r\nFile test" + i + ".txt have " + fs.Length + " bytes");
                    Console.WriteLine("File content:");
                    int temp = -1;
                    while ((temp = fs.ReadByte()) != -1)
                    {
                        Console.Write("{0} ",temp);
                    }
                }
            }*/

            /*
            BinaryWriter bw = new BinaryWriter(File.OpenWrite("test.txt"));
            bw.Write(5);
            bw.Write(5M);
            bw.Write(5.5);
            bw.Write(5==5);
            bw.Close();
            Console.WriteLine("file Length: {0}", File.ReadAllBytes("test.txt").Length);*/
            /*
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "welcome for all of you");
            Console.WriteLine("File Name: " + path);
            Console.WriteLine(File.ReadAllText(path));
            File.Delete(path);*/

            /*DirectoryInfo dir1 = new DirectoryInfo("E:\\NPTest");
            if (!dir1.Exists)
            {
                dir1.Create();
            }
            for (int i = 0; i < 10; i++)
            {
                dir1.CreateSubdirectory("test" + i);
            }
            DirectoryInfo[] dir = dir1.GetDirectories();//.GetFiles("",SearchOption.AllDirectories)
            foreach (DirectoryInfo d in dir)
            {
                Console.WriteLine(d.FullName);
            }*/

        }

        private static void getdata()
        {
            Console.WriteLine("Value of key is : "+AppDomain.CurrentDomain.GetData("key")+" in Thread Id: "+AppDomain.CurrentDomain.FriendlyName);

        }
    }
}
