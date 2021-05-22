using System;
using System.Threading;

namespace _3cSharp
{
    abstract class Vehicle
    {
        public string Type { get; set; }
        public int Speed { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public bool IsBroken { get; set; }
        public int Distance { get; set; }
        public Vehicle(string type = "car", int speed = 60, int wheels = 4, string color = "white", bool isBroken = false, int distance = 0)
        {
            Type = type;
            Speed = speed;
            Wheels = wheels;
            Color = color;
            IsBroken = isBroken;
            Distance = distance;
        }
        public string Condition()
        {
            return IsBroken ? "This vehicle is Broken." : "It's not broken for now";
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Type : {0}\nColor : {1}\nWheels : {2}\nSpeed : {3}\nDistance : {4}\n{5}", Type, Color, Wheels, Speed, Distance, Condition());
        }
        public virtual void Ride()
        {
            if (IsBroken)
            {
                Console.WriteLine("This Vehicle is broken, repair it first");
                Console.ReadKey();
                return;
            }
            Random rand = new Random();
            Console.WriteLine("Riding for 1 hour...");
            Distance += Speed;
            int chance = rand.Next(1, 4);
            IsBroken = chance == 2 ? true : false;
            if (IsBroken)
            {
                Console.Clear();
                Console.WriteLine("Your vehicle was broken.");
                Console.ReadKey();
            }
        }
        public void Repair()
        {
            Console.WriteLine("Oh, look at what you've done... Okay give me some time. I'll try to repair this junk");
            IsBroken = false;
            Console.ReadKey();
        }
    }
}
