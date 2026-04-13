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
        public string ToUpperCase(string text)
        {
            if (text == null) return null;
            return text.ToUpper();
        }

        public string ToLowerCase(string text)
        {
            if (text == null) return null;
            return text.ToLower();
        }
    }
}
