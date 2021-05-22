using System;
using System.Threading;

namespace _3cSharp
{
    class Bike : Vehicle, IMovable
    {
        public Bike(int speed = 60, int wheels = 4, string color = "white", bool isBroken = false, int distance = 0)
                : base("bike", speed, wheels, color, isBroken, distance)
        {
        }
        public void Ride()
        {
            if (IsBroken)
            {
                Console.WriteLine("The Bike is broken, repair it first");
                Console.ReadKey();
                return;
            }
            Random rand = new Random();
            Console.WriteLine("Riding for 1 hour...");
            Thread.Sleep(1000);
            Distance += Speed;
            int chance = rand.Next(1, 4);
            IsBroken = chance == 2 ? true : false;
            if (IsBroken)
            {
                Console.Clear();
                Console.WriteLine("The Bike was broken.");
                Console.ReadKey();
            }
        }
    }
}
