using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100000000,x=>Function1());
            Console.ReadLine();
        }
        static void Function1()
        {
            string x = "";
            for (int i = 0; i < 100000000; i++) x = x + ".";
        }
    }
}
