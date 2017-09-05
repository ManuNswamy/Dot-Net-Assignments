using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread_object = new Thread(function1);
            thread_object.Start();
            Console.WriteLine("Main Thread Exited");
        }
        static void function1()
        {
            Console.WriteLine("Funnctional Thread entered");
            Console.ReadLine();
        }
    }
}
