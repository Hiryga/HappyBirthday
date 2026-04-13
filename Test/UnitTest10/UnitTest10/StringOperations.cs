using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTest1
{
    internal class StringOperations
    {
        public bool IsEmpty(string text)
        {
            return text == null || text.Length == 0;
        }

        public int CountSpaces(string text)
        {
            if (text == null) return 0;

            int count = 0;
            foreach (char c in text)
            {
                if (c == ' ') count++;
            }
            return count;
        }
    }
}
