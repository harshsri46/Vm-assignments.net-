using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 6,8,18,60 };
            int[] insertedArray = new int[inputArray.Length];
            Stack < int> stackArray = new Stack<int>(inputArray);//taking array as a stack

            // Console.WriteLine(stackArray.Count);
            Console.WriteLine("Item in the stack:");
            for(int i=0;i<inputArray.Length;i++)
            {
                Console.Write(inputArray[i]+" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Implementing push");
            //for adding elements in stack
            int[] add=push(inputArray);
            for(int i = 0;i<add.Length;i++)
            {
                Console.Write(add[i]+ " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            //for deleting elements in stack
            Console.WriteLine("Implementing pop :");
            int[] delete=pop(inputArray);
            for (int i = 0; i < delete.Length; i++)
            {
                Console.Write(delete[i]+ " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            //for peek elements in stack
            Console.WriteLine("Implementing Peek:");
            int fetch=peek(inputArray);
            Console.WriteLine(fetch);
            

        }

        public static int[] push(int []inputArray)
        {
            int[] insertedArray = new int[inputArray.Length+1];
            Console.WriteLine("Enter element you want to push");
            int element= Convert.ToInt32(Console.ReadLine());

            insertedArray[0] = element;
            for (int i = 0; i < inputArray.Length; i++) {
                insertedArray[i + 1] = inputArray[i];
            }
            return insertedArray;
        }

        public static int[] pop(int[] inputArray)
        {
            int[] insertedArray = new int[inputArray.Length - 1];

            for (int i = 0; i < insertedArray.Length; i++)
            {
                insertedArray[i] = inputArray[i+1];
            }
            return insertedArray;
        }

        public static int peek(int[] inputArray)
        {
            //int[] insertedArray = new int[inputArray.Length ];
            int peekelement=inputArray[0];
            return peekelement;

        }

    }
}
