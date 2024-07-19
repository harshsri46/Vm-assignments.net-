using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generrics_Interface.ISimpleStack<int>;

namespace Generrics_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                SimpleStack<int> stack = new SimpleStack<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);


                Console.WriteLine("Peek:" + stack.Peek());

                //pop elements from stack
                Console.WriteLine("Pop:" + stack.Pop());
                Console.WriteLine("Pop:" + stack.Pop());

                //check the top element
                Console.WriteLine("Peek:" + stack.Peek());

                //pop the last element
                Console.WriteLine("Pop:" + stack.Pop());
                // Console.WriteLine("Pop:" + stack.Pop());

                try
                {
                    stack.Pop();
                }

                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Exception:" + ex.Message);
                }


            }
        }

    }
    }

