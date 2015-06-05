using System;
using System.Security.Permissions;
using System.Threading;
using System.IO;
using System.Text;
using Microsoft.Win32;


class ThreadInterrupt
{
    static void Main()
    {

        //BinaryReader br=new BinaryReader(File.OpenRead("E:\\Network.Client.Cs");
        string content = File.ReadAllText("E:\\Server_Test.cs");
        int index1=0,index2=0;
        while ((index1 = content.IndexOf("//",index2)) != -1)
        {
            index2 = content.IndexOf(Environment.NewLine, index1);
            Console.WriteLine(index1.ToString() + "    " + index2.ToString());
            if(index2!=-1)
                content= content.Remove(index1, index2 - index1+2);

        }
        File.WriteAllText("E:\\Server_Test.cs", content);

    }
}
