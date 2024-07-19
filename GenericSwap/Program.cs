using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwap
{
   
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"Before swapping: x= {x} and y= {y}");
            Swap( ref x, ref y );
            Console.WriteLine($"After swapping: x={x} and y={y}");

            string str1 = "hello";
            string str2 = " Harsh";

            Console.WriteLine($"Before swapping: str1= {str1} and str2= {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"After swapping: x={str1} and y={str2}");


        }
    }

}
