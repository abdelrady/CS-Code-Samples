using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace ch3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  pro 7
             * Console.WriteLine("Enter Two Numbers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);*/
            
            /*  pro 8
             * Console.WriteLine("Enter Radius:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diameter=" + 2 * a + "\nCirc=" + 2 * Math.PI * a + "\nArea=" + Math.PI * a * a);*/

            /* pro 11,12
             * MessageBox.Show("*\n**\n***\n****");     
             * */
            /* pro 14
             * Console.WriteLine("Enter Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % b == 0 ? "True" : "False");
             * */
            /*pro 15
             * for(int a=0 ;a<=257;a++)
            {
                Console.WriteLine((Char)a);
            }
        */
            /*
             * pro 16
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            
            int i = 0;
            while (a != 0)
            {
                arr[i++] = a % 10;
                a /= 10;
            }
            int length=i,tmp;
            for (int j = 0; j < i / 2;j++,i-- )
            {
                tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = arr[j];
            }
            for (i = 0; i < length; i++)
                Console.Write("{0} ", arr[i]);
            */
            /*
             * pro 17
             * Console.WriteLine("Number\tSquare\tCube");
            for (int i = 0; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            */
            String first=Console.ReadLine();
            String last = Console.ReadLine();
            //Console.WriteLine(first+' '+last);
            Console.WriteLine("{0} {1}",first , last);
        }
    }
}
