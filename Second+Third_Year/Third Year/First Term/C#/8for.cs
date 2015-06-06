using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int s=0;s<10;s++)
                for(int e=0;e<10;e++)
                    for(int n=0;n<10;n++)
                        for(int d=0;d<10;d++)
                            for(int m=1;m<10;m++)
                                for(int o=0;o<10;o++)
                                    for(int r=0;r<10;r++)
                                        for (int y = 0; y < 10; y++)
                                        {
                                            if (s != e && s!= n && s!= d && s!= m && s!= o && s!= r && s!= y)
                                                if (e != n && e!= d && e!= m && e!= o && e!= r && e!= y)
                                                    if (n != d && n!= m && n!= o && n!= r && n!= y)
                                                        if (d != m && d!= o && d!= r && d!= y)
                                                            if (m != o && m!= r && m!= y)
                                                                if (o != r && o!= y)
                                                                    if (r != y)
                                                                       if((s*1000+e*100+n*10+d+m*1000+o*100+r*10+e)==(m*10000+o*1000+n*100+e*10+y))
                                                                        Console.WriteLine("s={0} , e={1} , n={2} , d={3} , m={4} , o={5} , r={6} , y={7} ", s, e, n, d, m, o, r, y);
                                        }
        }
    }
}
