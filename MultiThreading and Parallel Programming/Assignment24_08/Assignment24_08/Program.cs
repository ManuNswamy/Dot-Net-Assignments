using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment24_08
{
   
    class Program
    {

        private static Semaphore s1 = null;

        static void Main(string[] args)
        {
            //Thread th_objA = new Thread(MultipleThreadDemo.functionA);
            //th_objA.IsBackground = true;//make the thread background
            //th_objA.Start();
            //Thread th_objB = new Thread(MultipleThreadDemo.functionB);
            //th_objB.IsBackground = true;//make the thread background
            //th_objB.Start();
            //Console.WriteLine("Exit from main thread");

            //Assignment3 as_obj = new Assignment3();

            //Thread th_obj = new Thread(as_obj.Divide);
            //th_obj.Start();
            //as_obj.Divide();
            //Assignment4.MutexDemo();

            try
            {
                s1 = Semaphore.OpenExisting("Test Demo");
            }
            catch(Exception e)
            {
                s1 = new Semaphore(3, 3, "TestDemo");
            }
            s1.WaitOne();
            Console.WriteLine("Thread Acquired");
            Console.ReadLine();
            s1.Release(); 


       
        }
       
    }
}
