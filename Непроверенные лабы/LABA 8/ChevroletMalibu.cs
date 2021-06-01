using System;

namespace _3cSharp
{
    class ChevroletMalibu : Car
    {
        public ChevroletMalibu(int fuel, bool isBroken, string color, int distance) : base(fuel, isBroken: isBroken, color: color, length: 2, height: 2, weight: 100, distance: distance)
        {
            Speed = 90;
            MaxFuel = 90;
            Consumption = 13;
            TypeOfCar = CarType.HatchBack;
            Wheels = 4;

        }
        public override void PrintInfo()
        {
            Console.WriteLine("Car : Chevrolet Malibu");
            Console.WriteLine("Type : " + TypeOfCar);
            base.PrintInfo();
        }

    }
}
