using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{
    internal class DeliveryParnter:Employee
    {
        public DeliveryParnter()
        {
        }
        public DeliveryParnter(string name, int age) : base(name,age)
        {

        }
        public DeliveryParnter(string name,string title,string gender,int age,float basesalary):base(name,title,gender,age,basesalary)
        {

        }
        public double calculateBonus()
        {
            return BaseSalary * 0.20;
        }

        public new void displaydetails()
        {
            base.displaydetails();
            Console.WriteLine($"Bonus:{calculateBonus()}");
        }
    }
}
