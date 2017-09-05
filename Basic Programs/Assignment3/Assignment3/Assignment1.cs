using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    static class Assignment1
    {
        public static void toFirstUpper(this string str)
        {
            string firstChar = str.Substring(0, 1).ToUpper();
            string result = firstChar + str.Substring(1, str.Length - 1).ToLower();
            Console.WriteLine(result);

           
        }
    }
}
