using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 50, 90, 40, 30, 20, 80, 70 };
           
            Console.WriteLine("Given Array");

            foreach(int item in  arr)
            {
                Console.WriteLine(item);
            }
            Array.Sort(arr);//sorting the array

            int index = Jmpsearch(arr);
            if (index == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine($"Element found at location {index}");


        }
        public static int Jmpsearch(int[] arr) 
        {
            int n=arr.Length;

            Console.WriteLine("Enter number to be searched");
            int searchedElement = Convert.ToInt32(Console.ReadLine());

            int step = (int)Math.Sqrt(n);//interval to be jumped

            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < searchedElement)
            {
                prev = step;
                step += (int)Math.Sqrt(n);

                if (prev >= n)
                    return -1;
            }
            
            
            for(int i=prev;i<Math.Min(step, n);i++)
            {
                if (arr[i] == searchedElement)
                    return i;
            }

            return -1;
        }
    }
}
