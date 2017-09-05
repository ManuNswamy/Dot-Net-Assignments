using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace Assignment14_08
{
    class BubbleSort
    {
        int[] numbers_array = new int[] { 97, 92, 81, 60, 2, 3, 1, 7, 2, 5, 99, 11, 42, 12, 61, 54, 22, 55, 55, 22, 122};
      
       

        public void SortingNormal()
        {
            var stop_watch = System.Diagnostics.Stopwatch.StartNew();    
           
            for (int j = 0; j <= numbers_array.Length - 2; j++)
            {
                for (int i = 0; i <= numbers_array.Length - 2; i++)
                {
                    if (numbers_array[i] > numbers_array[i + 1])
                    {
                        int t = numbers_array[i + 1];
                        numbers_array[i + 1] = numbers_array[i];
                        numbers_array[i] = t ;
                    }
                }
            }
            stop_watch.Stop();
            Console.WriteLine("sorting time of normal algorithm : {0}", stop_watch.ElapsedTicks);
        }

        public void SortingOptimized()
        {
            bool swap_performed = false;

            var stop_watch = System.Diagnostics.Stopwatch.StartNew();        

            for (int index = 1; index <= numbers_array.Length; index++)
            {            
                if(index==numbers_array.Length)
                {
                    if (swap_performed==true)
                        break;
                    else
                    {
                        swap_performed = false;
                        index = 1;
                    }                    
                }
                if (numbers_array[index-1] < numbers_array[index] )
                {
                    numbers_array[index] = numbers_array[index]+ numbers_array[index-1];
                    numbers_array[index-1] = numbers_array[index]- numbers_array[index-1];
                    numbers_array[index] = numbers_array[index]- numbers_array[index-1];
                    swap_performed = true;
                }
                
            }
            stop_watch.Stop();
            Console.WriteLine("sorting time of optimized algorithm : {0}", stop_watch.ElapsedTicks);

        }
        
    }
}
