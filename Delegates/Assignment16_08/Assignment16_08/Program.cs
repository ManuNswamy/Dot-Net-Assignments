using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_08
{
    public delegate double CalculateSimpleInterest(double principle1,double year1, double rate1);
    public delegate void CalculateSimpleInterestVoid();
    class Program
    {
        public static double getTotalInterest(double principle, double year, double rate)
        {
            double temp = principle * year * rate;
            temp = temp / 100;
            return temp;
        }
        public static double getTotalInterestPerYear(double principle, double year, double rate)
        {
            double temp = principle * year * rate+1000;
            temp = temp / 100;
            return temp;
        }

        public static void displayA()
        {
            Console.WriteLine("FROM METHOD 1");
        }
        public static void displayB()
        {
            Console.WriteLine("FROM METHOD 2");
        }




        static void Main(string[] args)
        {
            //Program program_obj = new Program();
            //Console.WriteLine($"Total Interest : {program_obj.getTotalInterest(1000, 2, 2.7)}");

            //CalculateSimpleInterest myDelegate = new CalculateSimpleInterest(getTotalInterest);//Initialization
            //Console.WriteLine($"Total Interest  : {myDelegate(1000, 2, 2.7)}");

            CalculateSimpleInterestVoid singleCast1 = displayA;
            CalculateSimpleInterestVoid singleCast2 = displayB;
            CalculateSimpleInterestVoid multiCast = singleCast1 + singleCast2;
            Console.WriteLine("SINGLE CAST");
            singleCast1();
            singleCast2();
            Console.WriteLine("");
            Console.WriteLine("MULTI CAST");
            multiCast();

            Console.WriteLine("");
            CalculateSimpleInterestVoid testDel = delegate () 
            {
                Console.WriteLine("HELLO TEST DEL (ANONYMOUS FUNCTION)");
            };
            testDel();

            
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();
            //Employee emp3 = new Employee();
            //Employee emp4 = new Employee();

            //emp1.AddEmployee(123, "Subramani", "IT", "Artifical Intelligence");
            //emp2.AddEmployee(124, "Harshada", "EXTC", "Networking");
            //emp3.AddEmployee(125, "Anitha", "IT", "Natural Language Processing");
            //emp4.AddEmployee(126, "Harshu", "Computers", "Game Programming");

            //emp4.display();

            Console.ReadLine();


        }
    }
}
