using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24_08
{
    public static class MultipleThreadDemo
    {
        public static void functionA()
        {
            Console.WriteLine("Enter Function A");
            Console.ReadLine();
            Console.WriteLine("Exit from A");
            Console.ReadLine();
        }
        public static void functionB()
        {
            Console.WriteLine("Enter Function B");
            Console.ReadLine();
            Console.WriteLine("Exit from B");
            Console.ReadLine();

        }
    }
}
