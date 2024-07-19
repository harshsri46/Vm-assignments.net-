using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping first:{a}, second:{b}");

            a = a ^ b;
            b = b ^ a;
            a=a ^ b;

            Console.WriteLine($"After swapping first:{a}, second:{b}");
        }
    }
}
