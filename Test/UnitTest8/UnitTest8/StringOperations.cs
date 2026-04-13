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
        public string Concat(string a, string b)
        {
            if (a == null) a = "";
            if (b == null) b = "";
            return a + b;
        }

        public bool Contains(string text, string word)
        {
            if (text == null || word == null) return false;
            return text.Contains(word);
        }
    }
}
