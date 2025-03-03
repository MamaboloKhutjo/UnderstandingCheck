using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCheck
{

    //creating a class (Constructor)
    class Employee
    {
     public  string Name, Company;
     public  int Age;

        public void IntroduceYourself()
        {
            Console.WriteLine("Hello, my name is: " + Name);
            Console.WriteLine("I work for: " + Company);
            Console.WriteLine("I am: " + Age + " years old");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create a variable of datatype "Employee" Which is the object
            Employee emplyee1 = new Employee();
            emplyee1.Name = "Khutjo Mamabolo";
            emplyee1.Company = "Sentinel Aerospace";
            emplyee1.Age = 21;
        }
    }
}
