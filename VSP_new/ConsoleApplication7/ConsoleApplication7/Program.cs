using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=1;x<100;x++)
                for(int yield=1;yield<100;yield++)
                    for (int z = 1; z < 100; z++)
                    {
                        if ((((50 * x) + (10 * yield) + (z)) == 1000) &&(x+yield+z==100))
                        {
                            Console.WriteLine("X= " + x.ToString() + " Y=" + yield.ToString() + " z=" + z.ToString());
                        }
                    }
        }
    }
}
