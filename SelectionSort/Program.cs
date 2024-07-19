using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 50, 90, 40, 30, 20, 80, 70 };
            Console.WriteLine("Given Array");
            DisplayArr(arr);
            Console.WriteLine();
            Console.WriteLine("------------------------Sorted Array------------------------");
            sortarray(arr);
            DisplayArr(arr);
            Console.WriteLine();
        }
        static void sortarray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                int minindex = i;
                for(int j = i+1;j < n; j++)
                {
                    if (arr[j] < arr[minindex])
                    {
                        minindex = j;
                    }
                
                   
                }
                //swap the found minimum element with first element
                
                int temp = arr[minindex];
                arr[minindex] = arr[i];
                arr[i]= temp;
            }
        }

        public static void DisplayArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


    }
}
