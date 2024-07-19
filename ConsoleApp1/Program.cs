using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[] { 1, 2, 4, 3, 3, 2, 5, 1 };

            var result=FindNonRepeating(intarray);
            Console.WriteLine($"The two non repeating elements are {result.Item1} and {result.Item2}");
        }

        public static (int,int) FindNonRepeating(int [] intarray )
        {
            int xorresult = 0;
                
            foreach(int num in intarray)
                {
                xorresult ^= num;
            }
            //find a setbit (right most set bit in this case)

            int setbit = xorresult & -xorresult;

            int num1 = 0;int num2 = 0;

            //divide elements in two groups and xor each group
            foreach(int num in intarray)
            {
                if((num&setbit)!=0)
                {
                    num1 ^= num;//xor of first group
                }
                else
                {
                    num2 ^= num;
                }
            }
            return (num1, num2);
        }
    }
}
