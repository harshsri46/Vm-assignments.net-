using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number:");
            int binary=Convert.ToInt32(Console.ReadLine());
            int original=binary;
            int Decimal= ConvertTodecima(binary);

            Console.WriteLine($"Decimal value of {original}={Decimal}");

        }
        public static int ConvertTodecima(int binarynum)
        {
            int base1 = 1;
            int decimalvalue = 0;
            while (binarynum > 0)
            {
                int rem = binarynum % 10;
                binarynum = binarynum / 10;
                 decimalvalue += rem * base1;
                base1=base1 * 2;
            }
            return decimalvalue;

        }

    }
}
