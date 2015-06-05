using System;
namespace test2
{
    public delegate void show(int x);
    public class counter
    {
        //public event show onshow;
        internal void show(string pass)
        {
            Console.WriteLine(this+", pass is: "+pass);
        }
        public void show(int x)
        {
            Console.WriteLine(this+"  "+x.ToString());
        }
        public void testDelegate(out show obj)
        {
            test2.show sh = delegate(int x)
            {
                show(x.ToString());
            };
            obj = sh;
            sh(3);
        }

        internal static string pass = "welcome internal hidden value";
    }
    public class count
    {
        void show()
        {
            Console.WriteLine(this);
        }

    }
}

