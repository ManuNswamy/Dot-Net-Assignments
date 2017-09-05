using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT NO: 01");
            string str = "abc";
            str.toFirstUpper();
            Console.WriteLine();

        
            Console.WriteLine("ASSIGNMENT NO: 02");
            int length = 10;
            Assignment4.AreaRectangle(length);
            Console.WriteLine();

            Console.WriteLine("ASSIGNMENT NO: 03 and 04");
            IVehicle vehicle1 = new Bikes();
            IVehicle vehicle2 = new Cars();

            Test(vehicle1);
            Test(vehicle2);


            Console.ReadLine();
        }

        public static void Test(IVehicle vc)
        {
            vc.seat();
            vc.brakes();
            vc.accelerator();
            vc.wheel();
        }


        
    }
}
