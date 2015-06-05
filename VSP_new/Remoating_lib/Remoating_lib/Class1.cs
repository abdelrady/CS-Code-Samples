using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Remoating_lib
{
    public class HelloServer : MarshalByRefObject
    {
        public void HelloMethod(ForwardMe obj)
        {
            obj.CallMe();
        }
    }
    public class ForwardMe : MarshalByRefObject
    {
        public void CallMe()
        {
            Console.WriteLine("CallMe was executed in: " +
               Process.GetCurrentProcess().ProcessName.ToString());
        }

    }

}
