using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generrics_Interface
{
    internal interface ISimpleStack<T>
    {
        void Push(T item);

        T Pop();

        T Peek();

        bool IsEmpty();


    }
}
