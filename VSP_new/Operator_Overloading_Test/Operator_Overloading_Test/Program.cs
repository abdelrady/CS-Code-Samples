//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Operator_Overloading_Test
//{
//    class Program
//    {
//        public Program()
//        {
//            val =5;
//        }
//        private int val;
//        public int Value
//        {
//            get
//            {
//                return val;
//            }
//        }
//        public static Program operator ++(Program p)
//        {
//            p.val++;
//            return p;
//        }
//        static Program pp = new Program();
//        static void Main(string[] args)
//        {
//            //test(pp++);
//            //Console.WriteLine("inside Main: " + pp.Value );
//            int x = 8;
//            test(x++);
//            Console.WriteLine("inside Main: " + x);
//        }

//        private static void test(Program program)
//        {
//            Console.WriteLine("inside Test: " + program.Value);
//        }
//        private static void test(int x)
//        {
//            Console.WriteLine("inside Test: " + x);
//        }
//    }
//}

/*using System;

// A three-dimensional coordinate class.
class ThreeD
{
    int x, y, z; // 3-D coordinates

    public ThreeD() { x = y = z = 0; }
    public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

    // Overload true.
    public static bool operator true(ThreeD op)
    {
        Console.WriteLine("Inside true Operator");
        if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            return true; // at least one coordinate is non-zero
        else
            return false;
    }

    // Overload false.
    public static bool operator false(ThreeD op)
    {
        //return false;
        Console.WriteLine("Inside False Operator");
        if ((op.x == 0) && (op.y == 0) && (op.z == 0))
            return true; // all coordinates are zero
        else
            return false;
    }

    // Overload unary --.
    public static ThreeD operator --(ThreeD op)
    {
        // for ++, modify argument
        op.x--;
        op.y--;
        op.z--;

        return op;
    }

    public static bool operator &(ThreeD op1, bool op2)
    {
        Console.WriteLine("inside 1 threeD obj");
        //if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
        //   ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
        if(TrueFalseDemo.test(op1) & op2)
            return true;
        else
            return false;
    }
    public static ThreeD operator &(ThreeD op1, ThreeD op2)
    {
        Console.WriteLine("inside 2 threeD obj");
        //ThreeD op2 = (ThreeD)opp2;
        ThreeD op3 = new ThreeD();
        op3.x = op1.x & op2.x;
        op3.y = op1.y & op2.y;
        op3.z = op1.z & op2.z;
        return op3;
    }


    // Show X, Y, Z coordinates.
    public void show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}

class TrueFalseDemo
{
    public static bool test(ThreeD obj)
    {
        Console.WriteLine("inside Test Method");
        if (obj) return true;
        return false;
    }
    public static bool test2(int x)
    {
        Console.WriteLine("inside Test2 Method");
        if (x > 0) return true;
        return false;
    }
    public static void Main()
    {
        if (true && test2(5))
            Console.WriteLine("See It...");
        else
            Console.WriteLine("Short Circuit...");
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(0, 0, 0);

        Console.Write("Here is a: ");
        a.show();
        Console.Write("Here is b: ");
        b.show();
        Console.Write("Here is c: ");
        c.show();
        Console.WriteLine();

        if ( a & test(b)) Console.WriteLine("a & b is true.");//test(a) & test(b)
        else Console.WriteLine("a & b is false.");

        Console.Write("Here is a & b numerically: ");
        (a & b).show();
        Console.WriteLine();
        return;
        if (a) Console.WriteLine("a is true.");
        else Console.WriteLine("a is false.");

        if (b) Console.WriteLine("b is true.");
        else Console.WriteLine("b is false.");

        if (c) Console.WriteLine("c is true.");
        else Console.WriteLine("c is false.");

        Console.WriteLine();

        Console.WriteLine("Control a loop using a ThreeD object.");
        do
        {
            b.show();
            b--;
        } while (b);

    }
}*/


using System;

// A three-dimensional coordinate class.
class ThreeD {
  int x, y, z; // 3-D coordinates

  public ThreeD() { x = y = z = 0; }
  public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

  // Overload | for short-circuit evaluation.
  public static ThreeD operator |(ThreeD op1, ThreeD op2)
  {
      Console.Write("inside | operator Object1: ");
      op1.show();
      Console.Write("\r\ninside | operator Object2: ");
      op2.show();
    if( ((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
       ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)) )
      return new ThreeD(1, 1, 1);
    else
      return new ThreeD(0, 0, 0);
  }

  // Overload & for short-circuit evaluation.
  public static ThreeD operator &(ThreeD op1, ThreeD op2)
  {
      Console.Write("inside & operator Object1: ");
      op1.show();
      Console.Write("\r\ninside & operator Object2: ");
      op2.show();
    if( ((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
       ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)) )
      return new ThreeD(1, 1, 1);
    else
      return new ThreeD(0, 0, 0);
  }
  
  // Overload !.
  public static bool operator !(ThreeD op)
  {
    if(op) return false;
    else return true;
  }

  // Overload true.
  public static bool operator true(ThreeD op) {
      Console.Write("inside true operator Object: ");
      op.show();
    if((op.x != 0) || (op.y != 0) || (op.z != 0))
      return true; // at least one coordinate is non-zero
    else
      return false;
  }

  // Overload false.
  public static bool operator false(ThreeD op) {
      Console.Write("inside false operator object: ");
      op.show();
    if((op.x == 0) && (op.y == 0) && (op.z == 0))
      return true; // all coordinates are zero
    else
      return false;
  }

  // Show X, Y, Z coordinates.
  public void show()
  {
    Console.WriteLine(x + ", " + y + ", " + z);
  }
}

class TrueFalseDemo {
  public static void Main() {
    ThreeD a = new ThreeD(5, 6, 7);
    ThreeD b = new ThreeD(10, 10, 10);
    ThreeD c = new ThreeD(0, 0, 0);

    Console.Write("Here is a: ");
    a.show();
    Console.Write("Here is b: ");
    b.show();
    Console.Write("Here is c: ");
    c.show();
    Console.WriteLine();

    if(a) Console.WriteLine("a is true.");
    if(b) Console.WriteLine("b is true.");
    if(c) Console.WriteLine("c is true.");

    if(!a) Console.WriteLine("a is false.");
    if(!b) Console.WriteLine("b is false.");
    if(!c) Console.WriteLine("c is false.");

    Console.WriteLine();
    Console.WriteLine("Use & and |");
    if(a & b) Console.WriteLine("a & b is true.");
    else Console.WriteLine("a & b is false.");

    if(a & c) Console.WriteLine("a & c is true.");
    else Console.WriteLine("a & c is false.");

    if(a | b) Console.WriteLine("a | b is true.");
    else Console.WriteLine("a | b is false.");

    if(a | c) Console.WriteLine("a | c is true.");
    else Console.WriteLine("a | c is false.");

    Console.WriteLine();

    // now use short-circuit ops
    Console.WriteLine("Use short-circuit && and ||");
    if(a && b) Console.WriteLine("a && b is true.");
    else Console.WriteLine("a && b is false.");

    if(c && a) Console.WriteLine("c && a is true.");
    else Console.WriteLine("c && a is false.");

    if(a || b) Console.WriteLine("a || b is true.");
    else Console.WriteLine("a || b is false.");

    if(c || a) Console.WriteLine("c || a is true.");
    else Console.WriteLine("c || a is false.");
  }
}