using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methodArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter size of array:");
            int size=Convert.ToInt32( Console.ReadLine());
            
            int[] arr =new int[size];

            Console.WriteLine("Enter the elements of array:");
            //taking the values of array from user
            for(int i=0;i<size;i++)
            {
                arr[i]= Convert.ToInt32( Console.ReadLine());
            }

            Console.WriteLine("Enter start index:");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end index");
            int b=Convert.ToInt32(Console.ReadLine());
            
            //for creating a slice of the array

            int[] result = SliceArray(arr,a,b,size);


            Console.WriteLine("sliced array:");
            
            for(int i=0;i<result.Length;i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter element to insert in array:");
            int elementtoinsert = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter position to insert element in array:");
            int positiontoinsert = Convert.ToInt32(Console.ReadLine());

            //for inserting elements in array at specific position
            int[] newArray = ArrayInsert(arr, elementtoinsert, positiontoinsert);
            Console.WriteLine("Array after inserting the element");
            for(int i=0;i< newArray.Length;i++)
            {
                Console.Write(newArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter element to be updated at index no.");
            int element = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            

            int[] updatedArray = UpdateArray(arr, index, element);
            for(int i=0;i<updatedArray.Length;i++)
            {
                Console.Write(updatedArray[i]+ " ");
            }

            int[] revArray=ReverseArray(arr);

            //for reversing the array
            Console.WriteLine();
            Console.WriteLine("Reversed Array");
            for(int i=0;i<revArray.Length;i++)
            {
                Console.Write(revArray[i] + " ");
            }

        }

        public static  int[] SliceArray(int[] arr,int start,int end,int size)
        {
            start=Math.Max(0,start);
            end= Math.Min(arr.Length-1,end);
            int arrsize = end-start + 1;
            
            int[] slicedArray = new int[arrsize];
            Array.Copy(arr, start, slicedArray, 0, arrsize);
            
            return slicedArray ;
        }

        public static int[] ArrayInsert(int[] arr,int element,int position)
        {
            int[] newArray= new int [arr.Length+1];///new array will be 1 greater than original 

            //copy the original array before adding the element
            for (int i = 0; i < position; i++)
            {
                newArray[i] = arr[i];
            }

            //adding the element at the position
            newArray[position]=element;

            for( int i=position;i<arr.Length;i++)
            {
                newArray[i+1]=arr[i];
            }

            return newArray ;

        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reverseArray=new int[arr.Length];//declaring a new array and give size equal to original array i.e, arr

            for(int i=0;i<arr.Length;i++)
            {
                reverseArray[i] = arr[arr.Length - 1 - i];
            }
            return reverseArray;
        }

        public static int[] UpdateArray(int[] arr,int index,int newvalue)
        {
            int[] newArray=new int[arr.Length];

            for(int i=0;i<index;i++)
            {
                newArray[i]=arr[i];
            }
            newArray[index]=newvalue;

            for( int i= index+1;i<arr.Length; i++)

            {
                newArray[i] = arr[i];
            }
            return newArray ;
        }
        
        
    }
}
