using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14_08
{
    class Count
    {
       
        public void Find()
        {
            var stop_watch = System.Diagnostics.Stopwatch.StartNew();
            int[] alphabet_count = new int[26];
            string input = "This is test statement";
            foreach (char c in input.ToUpper())
            {
                int index = (c)-65;
                if(index>=0 && index < 97)
                {
                    alphabet_count[index] = alphabet_count[index] + 1;
                }
               
            }
            int index_value = 0;
            foreach (int number in alphabet_count)
            {
                if (number > 0)
                {                 
                    char c = Convert.ToChar(index_value + 65);
                    //Console.WriteLine("COUNT OF {0} is {1}",c, number);
                }
                index_value++;
            }
            stop_watch.Stop();
            Console.WriteLine("sorting time of normal algorithm : {0}", stop_watch.ElapsedTicks);
        }
    }
}
