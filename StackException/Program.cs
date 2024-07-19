using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> p= new Stack<int>(5);
            p.Push(5);
            p.Push(18);
            p.Push(37);
            
            
            p.Pop();
            Console.WriteLine("element peeked");
            p.Peek();
        }
    }
}
