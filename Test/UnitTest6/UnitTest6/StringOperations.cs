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
        public string Reverse(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public int GetLength(string text)
        {
            if (text == null) return 0;
            return text.Length;
        }
    }
}
