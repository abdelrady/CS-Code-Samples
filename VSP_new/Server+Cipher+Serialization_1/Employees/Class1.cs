using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    [Serializable]
   public class SerialEmployee
    {
        public int EmployeeID; public string LastName, FirstName;
        public int YearsService;
        public double Salary;
       public void ShowResult(Employees.SerialEmployee emp1)
       {
           Console.WriteLine("emp"+count+ ".EmployeeID = {0}", emp1.EmployeeID);
           Console.WriteLine("emp" + count + ".LastName = {0}", emp1.LastName);
           Console.WriteLine("emp" + count + ".FirstName = {0}", emp1.FirstName);
           Console.WriteLine("emp" + count + ".YearsService = {0}", emp1.YearsService);
           Console.WriteLine("emp" + (count++) + ".Salary = {0}\n", emp1.Salary);
        
       }
       static int count = 1;
    }

}
