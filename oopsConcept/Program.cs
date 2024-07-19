using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp =new Employee("harsh","developer","male",27,56000);
            emp.displaydetails();
            Console.WriteLine("--------------------------------------");
            Employee emp2 = new Manager("ravi", "tester", "male", 24, 38000);
            emp2.displaydetails();
            Console.WriteLine("--------------------------------------");
            Employee emp3 = new DeliveryParnter("supriya", "tester", "female", 26, 35000);
            emp3.displaydetails();
        }
    }
}
