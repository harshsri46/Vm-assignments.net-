using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{
    internal class Manager:Employee
    {
        public Manager():base()
        { 
        }

        public Manager(string name, int age) : base(name,age)
        {

        }
        public Manager(string name, string title, string gender, int age, float salary) : base(name, title, gender, age, salary)
        {

        }

        public double calculateBonus()
        {
            return BaseSalary * 0.10;
        }

        public new void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine($"Bonus:{calculateBonus()}");
        }


    }
}
