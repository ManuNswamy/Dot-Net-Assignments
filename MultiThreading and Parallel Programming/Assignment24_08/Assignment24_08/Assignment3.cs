using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24_08
{
    public class Assignment3
    {
        static int randomNumber1;
        static int randomNumber2;

        public void Divide()
        {
            
            Random random = new Random();
            for(long i=0;i<100000;i++)
            {
                lock (this)
                {
                    randomNumber1 = random.Next(1, 300);
                    randomNumber2 = random.Next(1, 300);                    
                    double result = randomNumber1 / randomNumber2;
                    randomNumber1 = 0;
                    randomNumber2 = 0;
                }
            }
            
           
        }
    }
}
