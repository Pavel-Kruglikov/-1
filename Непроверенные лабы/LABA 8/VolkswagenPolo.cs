using System;
using System.Collections.Generic;
using System.Text;

namespace _3cSharp
{
    class VolkswagenPolo : Car, IVolkswagenEngine
    {

        bool EngineOHeat { get; set; }
        public VolkswagenPolo(int fuel, string color) :
            base(fuel, isBroken: false, color: color, length: 2, height: 2, weight: 100, distance: 0)
        {
            Speed = 90;
            MaxFuel = 90;
            Consumption = 12;
            TypeOfCar = CarType.HatchBack;
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
            Console.WriteLine("The Engine is repaired. Speed is 90 now");
            EngineOHeat = false;
            Speed = 90;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("Car : VolkswagenPolo");
            Console.WriteLine("Type : " + TypeOfCar);
            base.PrintInfo();

            if (EngineOHeat)
                Console.WriteLine("Engine is overheated, repair is needed\n");
        }

    }
}
