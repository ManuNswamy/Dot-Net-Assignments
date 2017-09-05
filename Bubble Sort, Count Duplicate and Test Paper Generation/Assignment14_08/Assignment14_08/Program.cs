using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Assignment14_08
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BubbleSort bs = new BubbleSort();
           // bs.SortingNormal();//sorting time of normal algorithm : 14
            bs.SortingOptimized();//sorting time of normal algorithm : 4

            Count cd = new Count();
            cd.Find();//1109 ticks with the console statement and 32 without the console statement

            TestPaper tp = new TestPaper();
            tp.generatePaper();
            Console.ReadLine();
        }
    }
}
