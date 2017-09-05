using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Calculation
    {
        public double add(int input1,int input2)
        {
            return (input1 + input2);
        }

        public double subtract(int input1, int input2)
        {
            return (input1 - input2);
        }

        public double multiply(int input1, int input2)
        {
            return (input1 * input2);
        }

        public double divide(int input1, int input2)
        {
            return (input1 / input2);
        }
    }
}
