using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14_08
{
    class TestPaper
    {
       
        int no_of_test_classes = 4;

        int[] no_of_questions_per_class = { 4, 4, 2, 1 };


        int sum = 0;

        int? current_set = null;

        public void generatePaper()
        {          

            var stop_watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < no_of_test_classes; i++)
                sum = sum + no_of_questions_per_class[i];
            while (sum!=0)
            {
                int max_value = no_of_questions_per_class.Max();
                int next_set = no_of_questions_per_class.ToList().IndexOf(max_value);
               
                if (current_set != null && current_set == next_set)
                {
                    max_value = no_of_questions_per_class.Where((number, index) => index != next_set).Max();
                    next_set = no_of_questions_per_class.ToList().IndexOf(max_value);
                    
                }
                
                Console.WriteLine(Convert.ToChar(next_set + 65));
                no_of_questions_per_class[next_set]--;
                sum--;
                current_set = next_set;
            }
            stop_watch.Stop();
            Console.WriteLine("sorting time of normal algorithm : {0}", stop_watch.Elapsed);
        }
       
    }
}




