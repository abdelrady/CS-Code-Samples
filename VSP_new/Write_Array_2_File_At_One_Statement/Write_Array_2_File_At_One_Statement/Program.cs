using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace Write_Array_2_File_At_One_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Welcome");
            ar.Add("Back");
            ar.Add("Abood");
            string[] str = (string[])ar.ToArray(typeof(string));
            StreamWriter sw = new StreamWriter("txtFile.txt");
            sw.Write("{0-}", str);
            sw.Close();
        }
    }
}
