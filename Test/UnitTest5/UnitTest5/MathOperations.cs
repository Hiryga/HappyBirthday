using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    internal class MathOperations
    {
        public double Max(int a, int b)
        {
            if (a >= b) return a;
            return b;
        }

        public int Min(int a, int b)
        {
            if (a <= b) return a;
            return b;
        }
    }
}
