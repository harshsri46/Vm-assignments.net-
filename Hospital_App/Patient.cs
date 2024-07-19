using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_App
{
    internal class Patient
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string Number { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }

        public Patient()
            {

            }

        public Patient(string firstname,string lastname,string gender,int age,string number,string state,string pincode)
        {
           this.firstName = firstname;
            this.lastName = lastname;
            this.gender = gender;
            this.age = age;
            this.Number=number;
            this.state = state;
            this.pincode = pincode;

        }



    }
}
