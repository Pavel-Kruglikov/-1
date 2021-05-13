using System;
namespace _3cSharp
{
    public enum CarType { HatchBack = 1, Sedan, Wagon };
    struct Dimension
    {
        public int height;
        public int weight;
        public int length;
        public Dimension(int Hght, int wght, int lngth)
        {
            height = Hght;
            weight = wght;
            length = lngth;
        }
    }
    class Car : Vehicle
    {
        public int Fuel { get; set; }
        public int MaxFuel { get; set; }
        public int Consumption { get; set; }
        public CarType TypeOfCar { get; set; }
        public Dimension Dimensions { get; set; }
        public Car(int fuel = 10, int maxFuel = 100, int consumption = 10, CarType cartype = (CarType)1,
            int height = 2, int length = 2, int weight = 50, int speed = 60, int wheels = 4, string color = "white", bool isBroken = false, int distance = 0)
                : base("car", speed, wheels, color, isBroken, distance)
        {
            Dimensions = new Dimension(height, weight, length);
            Fuel = (fuel > maxFuel) ? maxFuel : fuel;
            MaxFuel = maxFuel;
            Consumption = consumption;
            TypeOfCar = cartype;
        }
        public override void Ride()
        {
            if (Fuel <= 0)
            {
                Console.WriteLine("You are out of fuel.");
                Console.ReadKey();
                return;
            }
            base.Ride();
            Fuel -= Consumption;
            if (Fuel <= 0)
            {
                Console.Clear();
                Console.WriteLine("Out of fuel");
                Console.ReadKey();
            }
        }
        public void FillFuel()
        {
            Console.Clear();
            Fuel = MaxFuel; ;
            Console.WriteLine("You are ready to drive. Now you have {0} L", Fuel);
            Console.ReadKey();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Fuel level : {0}\nMaximum Fuel : {1}\nFuel Consumption : {2}\nDimensions :" +
                "length : {3}, height : {4}, weight : {5}\n", Fuel, MaxFuel, Consumption, Dimensions.length, Dimensions.height, Dimensions.weight);
        }
    }
}
