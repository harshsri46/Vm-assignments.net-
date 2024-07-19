using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 10, 50, 90, 40, 30, 20, 80, 70 };
            Console.WriteLine("Given Array");
            Display(arr);

           Console.WriteLine();
            SortArray(arr);

            Console.WriteLine("Sorted Array");
            Display(arr);

        }
        public static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length -1;i++)
            {
                for (int j =0; j < arr.Length-i-1;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
