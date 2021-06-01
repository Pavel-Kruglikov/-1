using System;
using System.Collections.Generic;
using System.Linq;

namespace _3cSharp
{
    class MainClass
    {
        static void AllVehicleInfo(List<Car> garage)
        {
            foreach (Car car in garage)
            {
                car.PrintInfo();
            }
        }

        static void BikeInfo(List<Bike> camp)
        {
            foreach (Bike vike in camp)
            {
                vike.PrintInfo();
            }
        }

        static void CarChoice(List<Car> garage, out int index)
        {

            int size = garage.Count();
            do
            {
                Console.WriteLine("Choose the vehicle by its id (from 0 to {0})", size - 1);
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"№ {i} - ");
                    garage[i].PrintInfo();
                }
                Assist.NumberCheck(Console.ReadLine(), out index);
            } while (index >= size);

            Console.Clear();

        }

        static void BikeChoice(List<Bike> garage, out int index)
        {
            int size = garage.Count();
            do
            {
                Console.WriteLine("Choose the vehicle by its id (from 0 to {0})", size - 1);
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"№ {i} - ");
                    garage[i].PrintInfo();
                }
                Assist.NumberCheck(Console.ReadLine(), out index);
            } while (index >= size);

            Console.Clear();

        }

        static public void ChooseAdd(List<Car> garage)
        {
            Console.WriteLine("What vehicle do you want to add : \n1 - Car\n2 - VolvoXC70\n3 - Volkswagen Golf\n4 - ChevroletMalibu\n5 - Exit ");
            switch (Console.ReadKey(false).Key)
            {

                case ConsoleKey.D1: Console.Clear(); garage.Add(AddNewCar(1)); Console.Clear(); break;

                case ConsoleKey.D2: Console.Clear(); garage.Add(AddNewCar(2)); Console.Clear(); break;

                case ConsoleKey.D3: Console.Clear(); garage.Add(AddNewCar(3)); Console.Clear(); break;

                case ConsoleKey.D4: Console.Clear(); garage.Add(AddNewCar(4)); Console.Clear(); break;

                case ConsoleKey.D5: return;
            }
        }
        static public Car AddNewCar(int flag)
        {
            if (flag == 1)
            {
                Console.WriteLine("Color : ");
                string color = Console.ReadLine();
                Console.WriteLine("Wheels : ");

                Assist.NumberCheck(Console.ReadLine(), out int wheels);

                Console.WriteLine("Speed : ");

                Assist.NumberCheck(Console.ReadLine(), out int speed);
                Console.WriteLine("Distance : ");

                Assist.NumberCheck(Console.ReadLine(), out int distance);
                Console.WriteLine(" Is it Broken ? ");

                bool izBroken = Assist.DefineBool(Console.ReadLine());

                Console.WriteLine("Fuel(in L) : ");
                Assist.NumberCheck(Console.ReadLine(), out int fuel);

                Console.WriteLine("Maximum Fuel(in L) : ");

                Assist.NumberCheck(Console.ReadLine(), out int maxFuel);

                Console.WriteLine("Fuel Consumption : ");
                Assist.NumberCheck(Console.ReadLine(), out int consumption);

                Console.WriteLine("Height : ");
                Assist.NumberCheck(Console.ReadLine(), out int height);

                Console.WriteLine("Length : ");
                Assist.NumberCheck(Console.ReadLine(), out int length);

                Console.WriteLine("Weight : ");
                Assist.NumberCheck(Console.ReadLine(), out int weight);

                return new Car(fuel, maxFuel, consumption, CarType.HatchBack, height, length, weight, speed, wheels, color, izBroken, distance);
            }
            else
            {
                Console.WriteLine("Color : ");
                string colour = Console.ReadLine();
                Console.WriteLine("Distance : ");
                Assist.NumberCheck(Console.ReadLine(), out int dist);
                Console.WriteLine("Fuel(in L) : ");
                Assist.NumberCheck(Console.ReadLine(), out int fue);
                Console.WriteLine("Is it Broken?");
                bool isBroken = Assist.DefineBool(Console.ReadLine());

                switch (flag)
                {
                    case 2: return new VolkswagenGolf(fue, isBroken, colour, dist);

                    case 3: return new VolvoXC70(fue, isBroken, colour, dist);

                    default: return new ChevroletMalibu(fue, isBroken, colour, dist);


                }
            }

        }

        static public Bike AddNewBike()
        {
            Console.WriteLine("Color : ");
            string color = Console.ReadLine();
            Console.WriteLine("Wheels : ");

            Assist.NumberCheck(Console.ReadLine(), out int wheels);
            Console.WriteLine("Speed : ");

            Assist.NumberCheck(Console.ReadLine(), out int speed);
            Console.WriteLine("Distance : ");

            Assist.NumberCheck(Console.ReadLine(), out int distance);
            Console.WriteLine("Broken : ");

            bool izBroken = Assist.DefineBool(Console.ReadLine());

            return new Bike(speed, wheels, color, izBroken, distance);
        }

        static void FuelSort(List<Car> garage)
        {

            for (int i = 0; i < garage.Count; i++)
            {
                for (int j = 0; j < garage.Count - 1; j++)
                {
                    if (garage[j].CompareTo(garage[j + 1]) >= 1)
                    {
                        Car b = garage[j];
                        garage[j] = garage[j + 1];
                        garage[j + 1] = b;
                    }
                }
            }

        }

        static public void BikeCamp(List<Bike> camp)
        {
            int index;
            do
            {
                Console.WriteLine("Your bike camp : \n1 - Add\n2 - Info\n3 - Throw Away\n4 - Test Drive\n" +
                                      "5 - Repair\n6 - Back");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.D1: Console.Clear(); camp.Add(AddNewBike()); Console.Clear(); break;

                    case ConsoleKey.D2: Console.Clear(); BikeInfo(camp); Console.ReadKey(); Console.Clear(); break;

                    case ConsoleKey.D3: Console.Clear(); BikeChoice(camp, out index); camp.Remove(camp[index]); Console.Clear(); break;

                    case ConsoleKey.D4: Console.Clear(); BikeChoice(camp, out index); camp[index].Ride(); Console.Clear(); break;

                    case ConsoleKey.D5: Console.Clear(); BikeChoice(camp, out index); camp[index].Repair(); Console.Clear(); break;

                    case ConsoleKey.D6: return;

                    default: Console.Clear(); break;
                }

            } while (true);


        }



        static void Main()
        {
            List<Car> garage = new List<Car>();
            List<Bike> camp = new List<Bike>();

            Car car = new Car();
            VolkswagenGolf golf = new VolkswagenGolf(100, true, "blue", 10);
            VolvoXC70 volvo = new VolvoXC70(50, true, "white", 100);
            ChevroletMalibu chevrolet = new ChevroletMalibu(0, false, "Orange", 20);
            VolkswagenPolo polo = new VolkswagenPolo(2, "yellow");
            Bike bike = new Bike(15, 2, "black", false, 0);

            garage.Add(car);
            garage.Add(volvo);
            garage.Add(chevrolet);
            garage.Add(golf);
            garage.Add(polo);
            camp.Add(bike);

            int index;
            do
            {
                Console.WriteLine("Your garage : \n1 - Add\n2 - Info about my vehicles\n3 - Throw Vehicle Away\n4 - Test Drive\n5 - Repair\n6 - Fill Fuel" +
                    "\n7 - Go to Bike camp\n8 - Exit");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.D1: Console.Clear(); ChooseAdd(garage); Console.Clear(); break;

                    case ConsoleKey.D2: Console.Clear(); FuelSort(garage); AllVehicleInfo(garage); Console.ReadKey(); Console.Clear(); break;

                    case ConsoleKey.D3: Console.Clear(); CarChoice(garage, out index); garage.Remove(garage[index]); Console.Clear(); break;

                    case ConsoleKey.D4: Console.Clear(); CarChoice(garage, out index); garage[index].Ride(); Console.Clear(); break;

                    case ConsoleKey.D5: Console.Clear(); CarChoice(garage, out index); garage[index].Repair(); Console.Clear(); break;

                    case ConsoleKey.D6: Console.Clear(); CarChoice(garage, out index); garage[index].FillFuel(); Console.Clear(); break;

                    case ConsoleKey.D7: Console.Clear(); BikeCamp(camp); Console.Clear(); break;

                    case ConsoleKey.D8: return;

                    default: Console.Clear(); break;
                }

            } while (true);


        }
    }
}