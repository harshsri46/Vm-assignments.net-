using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNunit
{
    public class Arithmetic
    {
        public int Add(int? first, int? second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("Input names cannot be null");
            }
            else
                return first.Value + second.Value;
        }
        public int substract(int? first, int? second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("Input names cannot be null");
            }
            else
            {
                return first.Value - second.Value;
            }

        }
        public int multiply(int? first, int? second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("Input names cannot be null");
            }
            else
            {
                return first.Value * second.Value;
            }

        }
        public double divide(int? first, double? second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException("Input names cannot be null");
            }
            else
            {
                return first.Value / second.Value;
            }

        }
    }
}
