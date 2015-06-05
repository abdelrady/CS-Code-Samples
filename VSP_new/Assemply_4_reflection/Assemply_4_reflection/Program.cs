// A file that contains three classes.  Call this file MyClasses.cs.

using System;

class MyClass
{
    int x;
    int y;
    internal int intObj;
    public MyClass(int i)
    {
        Console.WriteLine("Constructing MyClass(int). ");
        x = y = i;
        show();
    }

    public MyClass(int i, int j)
    {
        Console.WriteLine("Constructing MyClass(int, int). ");
        x = i;
        y = j;
        show();
    }

    public int sum()
    {
        return x + y;
    }
    public bool isBetween(int i)
    {
        if ((x < i) && (i < y)) return true;
        else return false;
    }

    public void set(int a, int b)
    {
        Console.Write("Inside set(int, int). ");
        x = a;
        y = b;
        show();
    }

    // Overload set.
    public void set(double a, double b)
    {
        Console.Write("Inside set(double, double). ");
        x = (int)a;
        y = (int)b;
        show();
    }

    public void show()
    {
        Console.WriteLine("Values are x: {0}, y: {1}", x, y);
        Console.WriteLine("Internal Objetc intObj: " + this.intObj.ToString());
    }
}

class AnotherClass
{
    string remark;

    public AnotherClass(string str)
    {
        remark = str;
    }

    public void show()
    {
        Console.WriteLine(remark);
    }
}

class Demo
{
    
    public static void Main(string[] argv)
    {
        Console.WriteLine("This is a placeholder.");
        foreach (string str in argv)
        {
            Console.Write("{0} , ", str);
        }
        Console.WriteLine();
        
    }
}
