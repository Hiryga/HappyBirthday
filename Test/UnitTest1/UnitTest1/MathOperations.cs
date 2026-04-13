using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    internal class MathOperations
    {
        public double Divide(int a, int b)
        {
            return a / b;
        }

        public int Power(int a, int b)
        {
            return(int)Math.Pow(a, b);
        }
    }
}
