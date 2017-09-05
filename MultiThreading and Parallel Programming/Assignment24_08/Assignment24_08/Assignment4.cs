using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment24_08
{
    static class Assignment4
    {
        public static void MutexDemo()
        {
            using (var mutex = new Mutex(false, "TestDemo"))
            {
                if(!mutex.WaitOne(5000,false))
                    { 
                    Console.WriteLine("Already an instance is running");
                    Console.ReadLine();
                    return;
                    }
                Console.WriteLine("App Running");
                Console.ReadLine();               
            }
        }
    }
}
