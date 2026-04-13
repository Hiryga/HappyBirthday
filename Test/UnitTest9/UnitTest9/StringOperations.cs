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
        public string FirstChar(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;
            return text[0].ToString();
        }

        public string LastChar(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;
            return text[text.Length - 1].ToString();
        }
    }
}
