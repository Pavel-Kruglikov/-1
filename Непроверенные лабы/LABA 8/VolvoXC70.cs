using System;


namespace _3cSharp
{
    class VolvoXC70 : Car
    {
        public VolvoXC70(int fuel, bool isBroken, string color, int distance) : base(fuel, isBroken: isBroken, color: color, length: 2, height: 2, weight: 100, distance: distance)
        {
            Speed = 60;
            MaxFuel = 100;
            Consumption = 10;
            TypeOfCar = CarType.Wagon;
            Wheels = 4;

        }
        public override void PrintInfo()
        {
            Console.WriteLine("Car : VolvoXC70");
            Console.WriteLine("Type : " + TypeOfCar);
            base.PrintInfo();
        }


    }
}