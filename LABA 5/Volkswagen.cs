using System;

namespace _3cSharp
{
    class VolkswagenGolf : Car
    {
        public VolkswagenGolf(int fuel, bool isBroken, string color, int distance) : base(fuel, isBroken: isBroken, color: color, length: 2, height: 2, weight: 100, distance: distance)
        {
            Speed = 50;
            MaxFuel = 120;
            Consumption = 7;
            TypeOfCar = CarType.Sedan;
            Wheels = 4;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Car : Volkswagen Golf");
            Console.WriteLine("Type : " + TypeOfCar);
            base.PrintInfo();
        }
    }
}
