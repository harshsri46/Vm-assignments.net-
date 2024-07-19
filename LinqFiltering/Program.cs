using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonDetails> person = new List<PersonDetails>
            {
                new PersonDetails("harsh","shrivastava",29),
                new PersonDetails("rahul","verma",32),
                new PersonDetails("arpit","singh",35),
                new PersonDetails("anshika","yadav",18),
              
                new PersonDetails("arpita","keshari",29)
            };

            Console.WriteLine("Before sorting");

            foreach (var item in person)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} {item.age}");
            }
            Console.WriteLine();

            Console.WriteLine("---------Person having Age >30------------");
            var names = person.Where(getdetails=>getdetails.age>30).Select(getdetails=>$"{getdetails.firstName}  {getdetails.lastName}");


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("--------------After Sorting------------------------- ");
            Console.WriteLine();

            var sortedPerson = person.OrderBy(getDetails => getDetails.lastName).ThenBy(getDetails => getDetails.firstName);

            foreach (var sortperson in sortedPerson)
            {
                Console.WriteLine($"{sortperson.firstName} {sortperson.lastName} {sortperson.age}");
            }
            Console.WriteLine();

            double average_age=person.Average(getDetails => getDetails.age);
            Console.WriteLine($"Average age ={average_age}");

            //int yougest =person.Min(getDetails => getDetails.age).
            int minAge = person.Min(getDetails => getDetails.age);
            var yougestPerson = person.First(p => p.age == minAge);

            Console.WriteLine($"Youngest Person -{yougestPerson.firstName} {yougestPerson.lastName}");

            int maxAge = person.Max(getDetails => getDetails.age);
            var oldestPerson = person.First(p => p.age == maxAge);

            Console.WriteLine($"Oldest Person - {oldestPerson.firstName} {oldestPerson.lastName}");

        }
    }
}
