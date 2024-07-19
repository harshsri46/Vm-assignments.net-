using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackpush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] intArray ={ 32,24,20,15,5};
            Stack<int> intstack = new Stack<int>(intArray);
            Console.WriteLine("Displaying items in stack:");
            Display(intstack);

           
            insert(intstack);

            Console.WriteLine("Displaying items in stack:");
            Display(intstack);

        }

        public static void insert(Stack<int> intstack)
        {
            Console.WriteLine("Enter the element to be pushed");
            int item=Convert.ToInt32(Console.ReadLine());
            intstack.Push(item);


        }
        public static void Display(Stack<int> intstack)
        {
            
            foreach( int i in intstack)
            {
                Console.WriteLine(i);
            }
        }

    }
}
