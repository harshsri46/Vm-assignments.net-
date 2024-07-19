using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManage
{
  
    public class Employee
    {
        public int id;
        public string name;
        private string position;
        private decimal salary;

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id must be positive");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Position cannot be empty");
                }
                position = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }

        public Employee(int id, string name, string position, decimal salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee id= {Id}");
            Console.WriteLine($"Employee Name= {Name}");
            Console.WriteLine($"Employee Position ={Position}");
            Console.WriteLine($"Employee salary={Salary}");
        }

        public decimal CalculateBonus(decimal percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException("percentage cannot be negative");
            }
            return Salary * (percentage / 100);
        }

        public void PrintPIValue(int number, string text)
        {
            Console.WriteLine($"Number ={number} text = {text}");
        }
      
    }
}
