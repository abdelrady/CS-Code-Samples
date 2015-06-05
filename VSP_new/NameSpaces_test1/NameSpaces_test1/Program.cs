using System;
using System.Collections.Generic;
using System.Text;
using test2;
using testx=test.test1.test2.counter;
class Program
{
    static void Main(string[] args)
    {
        testx c = new testx();
        //c.show();

         test2.counter c2 = new test2.counter();
         test2.show testdelg = null;
         c2.testDelegate(out testdelg);
         testdelg += c.show;
         testdelg += c.show;
         testdelg(4);
         testdelg -= c.show;
         Console.WriteLine();
         testdelg(5);
    }
}

namespace test.test1.test2
{
    class counter
    {
        public void show(int x)
        {
            Console.WriteLine(this+", pass= "+x.ToString());
        }
    }
}