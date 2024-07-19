using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        
        public int Age {  get; set; }

        public string Gender {  get; set; }

        public double BaseSalary { get; set; }

        public Employee()
        {

        }//defualt constructor

        public Employee(string Name, int Age)
        {
            this.Name = Name;
            this.Age= Age;
            this.BaseSalary = 500;
        }
        public Employee(string Name,string title,string gender,int Age,float basesalary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender= gender;
            this.Title = title;
            this.BaseSalary= basesalary;
        }
       
        public virtual void displaydetails()
        {
            Console.WriteLine("Name:"+ Name);
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("Age:"+Age);
            Console.WriteLine("salary:" + BaseSalary);
        }

    }
}
