using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackException
{
    internal class ImplementStack
    {
        private int top;
        private int max;
        private int[] ele;

        public ImplementStack(int size)
        {
            top = -1;
            max = size;
            ele = new int[size];    //maximum size of stack
        }
        public void push(int item)
        {
            if (top == max - 1)
            { Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                ele[++top]=item;
            }
        }

        public int pop()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"{0} poped from stack", ele[top]);
                return ele[top--];
            }
        }

        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"{0} poped from stack", ele[top]);
                return ele[top];
            }
        }

        public void  printstack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return ;
            }
            else
            {
                for(int i = 0; i < top; i++)
                {
                    Console.WriteLine($"{0} pushed into stack", ele[i]);
                }
            }
        }
    }
}
