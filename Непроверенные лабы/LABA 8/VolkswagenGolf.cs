using System;

namespace _3cSharp
{
    class VolkswagenGolf : Car, IVolkswagenEngine
    {
        bool EngineOHeat { get; set; }
        public VolkswagenGolf(int fuel, bool isBroken, string color, int distance) :
            base(fuel, isBroken: isBroken, color: color, length: 2, height: 2, weight: 100, distance: distance)
        {
            Speed = 50;
            MaxFuel = 120;
            Consumption = 7;
            TypeOfCar = CarType.Sedan;
            Wheels = 4;

        }

        public void OverHeat()
        {
            Console.WriteLine("The Engine is overheated, speed = 0");
            EngineOHeat = true;
            Speed = 0;
            Console.ReadKey();

        }

        public void EngineRepair()
        {
            Console.WriteLine("The Engine is repaired. Speed is 50 now");
            EngineOHeat = false;
            Speed = 50;
        }

        public override void Ride()
        {
            Random rand = new Random();

            if (rand.Next(1, 5) == 3)
                OverHeat();

            base.Ride();

        }

        public override void Repair()
        {
            EngineRepair();
            base.Repair();
        }





        public override void PrintInfo()
        {
            Console.WriteLine("Car : VolkswagenGolf");
            Console.WriteLine("Type : " + TypeOfCar);
            base.PrintInfo();
            if (EngineOHeat)
                Console.WriteLine("Engine is overheated, repair is needed");
        }

    }
}