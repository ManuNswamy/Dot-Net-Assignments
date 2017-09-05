using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace Assignment22_08_Exception
{
    class MathException:Exception
    {
        public MathException(string message): base(message)
            {
            }
    }
   
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two inputs");
            int input1=0;
            int input2=0;
            MathException exception = new MathException("DIVIDE BY ZERO");
       

            try
            {
                 input1 = Convert.ToInt32(Console.ReadLine());
                 input2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception");
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
              
            }
            Console.WriteLine("Enter the Operation to be performed");
            Console.WriteLine("+ :Addition      - : Subtraction     * : Multiplication     / : Division");
            char choice = Convert.ToChar(Console.ReadLine());
            Calculation cal = new Calculation();
            try
            {
                switch (choice)
                {


                    case '+':
                        Console.WriteLine($"Result is {cal.add(input1, input2)}");
                        break;

                    case '-':
                            Console.WriteLine($"Result is {cal.subtract(input1, input2)}");
                            break;

                    case '*':
                            Console.WriteLine($"Result is {cal.multiply(input1, input2)}");
                            break;

                    case '/':
                            Console.WriteLine($"Result is {cal.divide(input1, input2)}");
                            break;
                        
                }
            }
            catch(DivideByZeroException)
            {
                try
                {
                    throw (exception);
                }
                catch (MathException e)
                {
                    Console.WriteLine("Exception ReRouted");
                }
           }
           
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception");
            }
            catch(FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
