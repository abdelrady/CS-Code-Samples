using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace reflection_test_assemply
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"E:\VSP_new\Assemply_4_reflection\Assemply_4_reflection\bin\Debug\Assemply_4_reflection.exe");
            Type[] t = asm.GetTypes();
            foreach (Type Tclass in t)
            {
                Console.WriteLine(Tclass.Name.CompareTo("MyClass"));
                if (Tclass.Name.CompareTo("MyClass") == 0)
                {
                    Console.WriteLine("Class Name Found...");
                    ConstructorInfo ci = Tclass.GetConstructors()[0];
                    ParameterInfo[] ppi = ci.GetParameters();
                    Console.WriteLine(ppi.Length.ToString());
                    object[] paramsobj = new object[ppi.Length];
                    paramsobj[0] = 12;
                    object classObj = ci.Invoke(paramsobj);
                    PropertyInfo pi = Tclass.GetProperty("intObj");
                    if (pi != null)
                    {
                        pi.GetSetMethod(true).Invoke(classObj, new object[1] { 16 });
                    }
                    else
                    {
                        Console.WriteLine("GetProperty Method Return Null..");
                    }
                    MemberInfo[] mii = Tclass.GetMembers(BindingFlags.Instance);
                    Console.WriteLine("Class Members Length: "+mii.Length.ToString());
                    foreach (MemberInfo p in mii)
                    {
                        Console.WriteLine(p.DeclaringType.ToString() + " " + p.Name);
                    }
                }
                Console.WriteLine("Class Name: " + Tclass.Name);
                MethodInfo[] mth= Tclass.GetMethods();
                for (int i = 0; i < mth.Length; i++)
                {
                    Console.Write("\t"+mth[i].ReturnParameter.ParameterType+" "+mth[i].Name+"( ");
                    ParameterInfo[] param = mth[i].GetParameters();
                    if (mth[i].Name.CompareTo("Main") == 0)
                    {
                        
                        string[] str ={ "1", "welcome" };
                        //mth[i].Invoke(null, new object[1] { str });
                    }
                    for (int j = 0; j < param.Length; j++)
                    {
                        Console.Write(param[j].ParameterType + " " + param[j].Name);
                        if (j + 1 != param.Length)
                            Console.Write(" , ");
                    }
                    Console.Write(");\r\n");
                }
            }

        }
    }
}
