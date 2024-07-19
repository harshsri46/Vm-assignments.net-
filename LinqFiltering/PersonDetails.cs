using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFiltering
{
    internal class PersonDetails
    {

        public string firstName {  get; set; }
        public string lastName { get; set; }
       
        public int age { get; set; }

        public PersonDetails()
        {

        }
        public PersonDetails(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

    }
}
