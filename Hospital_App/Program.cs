using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_App
{
    internal class Program
    {
        
        public enum Department
        { General=400,
            ENT=800,
            Cardiology=1200,
            OperationTheater=5000,
            IntensiveCareUnit=6000

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome  to ABC Hospital");

            Console.WriteLine("Select the department for treatment");

            Console.WriteLine("1.General:400");

            Console.WriteLine("2.ENT:800");

            Console.WriteLine("3.Cardiology:1200");

            Console.WriteLine("4.OperationTheater:5000");

            Console.WriteLine("5.IntensiveCareUnit:6000");

            int input=Convert.ToInt32(Console.ReadLine());

            string selectedDepartment = string.Empty;

            switch(input)
            {
                case 1:
                    { selectedDepartment = nameof(Department.General);
                        break;
                    }

                case 2:
                    {
                        selectedDepartment=nameof(Department.ENT);
                        break;
                    }   
                case 3:
                    {
                        selectedDepartment=nameof(Department.Cardiology);
                        break;
                    }
                case 4:
                    {
                        selectedDepartment=nameof(Department.OperationTheater);
                        break;
                    }

                case 5:
                    {
                        selectedDepartment=nameof(Department.IntensiveCareUnit);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection");
                        break;
                    }
            }

            Console.WriteLine($"Department selected : {selectedDepartment}");
            Console.WriteLine("Enter Patient Details");

            Patient[] patients = new Patient[3];
            for (int i = 0; i < patients.Length; i++)
            {
                Console.WriteLine($"Enter details for patient {i + 1}");

                Console.WriteLine("Enter first Name");

                string firstName = Console.ReadLine();

                Console.WriteLine("Enter last Name");

                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Gender");

                string gender = Console.ReadLine();

                Console.WriteLine("Enter age");

                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter phone number");

                string number = Console.ReadLine();

                Console.WriteLine("Enter state");

                string state = Console.ReadLine();

                Console.WriteLine("Enter pincode");

                string pincode = Console.ReadLine();

                patients[i]=new Patient(firstName,lastName,gender,age,number,state,pincode);

                Console.WriteLine();
            }
            Console.WriteLine("Search patient details through contact number");
            Console.WriteLine("Enter contact number");
            string contactinfo= Console.ReadLine();

            bool patientfound = false;

            foreach(var item in patients)
            {
               if( item.Number == contactinfo)
                {
                    Console.WriteLine($"Firstname :{item.firstName}");
                    Console.WriteLine($"Lastname :{item.lastName}");
                    Console.WriteLine($"Gender :{item.gender}");
                    Console.WriteLine($"Age :{item.age}");
                    Console.WriteLine($"Phone Number :{item.Number}");
                    Console.WriteLine($"State :{item.state}");
                    Console.WriteLine($"Pincode :{item.pincode}");

                    patientfound = true;
                    break;
                }
            }

            if(!patientfound)
            {
                Console.WriteLine("No patient found with this phone number:");
            }
            


        }
    }
}
