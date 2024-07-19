using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConversion
{
   
    internal class Program
    {
        public delegate void numberDelegate(int num);//delegate declaration
        public static void message(int num)
        {
            Console.WriteLine($"Message from delegate is= {num}");
        }

        public static void DisplayNumbers(int num,numberDelegate ConvertToString)
        {
            for (int i = 1; i <= num; i++)
            {
                ConvertToString(i);
            }
        }
        static void Main(string[] args)
        {

          
            numberDelegate ConvertToString = new numberDelegate(Program.message);   
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            DisplayNumbers(num, ConvertToString);
            
            

        }
        
       
    }
}
