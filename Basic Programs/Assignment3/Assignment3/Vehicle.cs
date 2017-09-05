using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    interface IVehicle
    {
        void wheel();
        void brakes();
        void accelerator();
        void seat();
    }
    class Bikes : IVehicle
    {
        public void accelerator()
        {
            Console.WriteLine("BIKE ACCELERATOR");
        }

        public void brakes()
        {
            Console.WriteLine("BIKE brakes");
        }

        public void wheel()
        {
            Console.WriteLine("BIKE wheels");
        }
        public void seat()
        {
            Console.WriteLine("Bike Seat is For 2");
        }
    }
    class Cars : IVehicle
    {
        public void accelerator()
        {
            Console.WriteLine("Car ACCELERATOR");
        }

        public void brakes()
        {
            Console.WriteLine("Car brakes");
        }

        public void wheel()
        {
            Console.WriteLine("Car wheels");
        }
        public void seat()
        {
            Console.WriteLine("Car seat is for 4");
        }
    }
}
