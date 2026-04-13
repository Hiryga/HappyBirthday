using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    internal class MathOperations
    {
        public double Substract(int a, int b)
        {
            return a - b;
        }

        public int Abs(int a)
        {
           if (a < 0) return -a;
           return a;
        }
    }
}
