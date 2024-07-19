using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleStack
{
    public  class SimpleStack<T>
    {
        private List<T> _elements;

        public SimpleStack()
        {
                _elements = new List<T>();
        }
        public void Push(T element)
        {
            Console.WriteLine($"{element} pushed into stack");
            _elements.Add(element);
        }

        public T Pop() 
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int lastindex= _elements.Count-1;//get the first element
            T element = _elements[lastindex];
            Console.WriteLine($"Item poped from stack");
            _elements.RemoveAt(lastindex);

            return element;
        }
        public T Peek()
        {
            if (_elements.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
           return _elements[_elements.Count - 1];
        }

        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
           SimpleStack <int> stack = new SimpleStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
           

            Console.WriteLine("Peek:"+ stack.Peek());

            //pop elements from stack
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());

            //check the top element
            Console.WriteLine("Peek:"+stack.Peek());

            //pop the last element
            Console.WriteLine("Pop:" + stack.Pop());
           // Console.WriteLine("Pop:" + stack.Pop());

            try
            {
                stack.Pop();
            }

            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Exception:"+ex.Message);
            }


        }
    }
}
