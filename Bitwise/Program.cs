using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int result = CountSetbits(i);
                Console.WriteLine($"Number of set bits count of {i}={result}");
            }
        }
        public static int CountSetbits(int num)
        {
            int count = 0;

            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }
            return count;
        }
    }
    
}
