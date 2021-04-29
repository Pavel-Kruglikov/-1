﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    public class Transport
    {
        public static int countTransport = 0;
        private static int idCount = 0;
        public string name { get; set; }
        public int idTransport { get; private set; }
        public int weight { get; set; }
        public double width { get; set; }
        public double length { get; set; }
        public int maxSpeed { get; set; }
        public typeTransport type { get; set; }
        public double cost { set; get; }
        public DateTime year { get; set; }
        public int passengers { get; set; }
        public enum typeTransport
        {
            land = 1,
            water = 2,
            air = 3,
            space = 4
        }
        public Transport(string newName, int newWeight, double newWidth, double newLength, int newMaxSpeed, typeTransport newType,
                            int newPassengers, DateTime newYear, double newCost)
            : this(newName, newWeight, newWidth, newLength, newMaxSpeed, newType)
        {
            passengers = newPassengers;
            year = newYear;
            cost = newCost;
        }
        public Transport(string newName, int newWeight, double newWidth, double newLength, int newMaxSpeed, typeTransport newType)
        {
            name = newName;
            idTransport = idCount;
            idCount++;
            countTransport++;
            weight = newWeight;
            width = newWidth;
            length = newLength;
            maxSpeed = newMaxSpeed;
            type = newType;
            year = new DateTime(1);
            cost = -1;
            passengers = -1;
        }
        public void outInfo()
        {
            Console.WriteLine($"Name: {name}\n");
            Console.WriteLine($"Id: {idTransport}\n");
            Console.WriteLine($"Weight: {weight}\n");
            Console.WriteLine($"Width: {width}\n");
            Console.WriteLine($"Legth: {length}\n");
            Console.WriteLine($"Max speed: {maxSpeed}\n");
            Console.WriteLine($"Type: {type}\n");
            Console.WriteLine("Passengers: " + (passengers == -1 ? " unknown" : passengers.ToString()));
            Console.WriteLine("Year: " + (year.Year == 1 ? " unknown\n" : year.Year.ToString()) + '\n');
            Console.WriteLine("Cost: " + (cost == -1 ? " unknown\n" : cost.ToString() + '\n'));
        }
    }
    class Program
    {
        static List<Transport> transports = new List<Transport>();
        static void inInfo()
        {
            Console.WriteLine("Name:\n");
            string newName = Console.ReadLine();
            int newWeight = GetInt("Weight:\n");
            double newWidth = GetDouble("Width:\n");
            double newLength = GetDouble("Length:\n");
            int newMaxSpeed = (GetInt("Max speed:\n"));
            Transport.typeTransport newType = GetType();
            Console.WriteLine("Do you want continue? (enter Y)");
            string check = Console.ReadLine().ToLower();
            if (check != "y")
            {
                transports.Add(new Transport(newName, newWeight, newWidth, newLength, newMaxSpeed, newType));
                return;
            }
            int newPassengers = GetInt("Passengers:\n");
            DateTime newYear = new DateTime(GetInt("Year\n"));
            double newCost = GetDouble("Cost:\n");
            transports.Add(new Transport(newName, newWeight, newWidth, newLength, newMaxSpeed, newType, newPassengers, newYear, newCost));
        }
        static int GetInt(string s)
        {
            bool flag = true;
            int res = 0;
            string input;
            while (flag)
            {
                flag = false;
                Console.WriteLine(s);
                input = Console.ReadLine();
                try
                {
                    res = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input.Try again.");
                    flag = true;
                }
            }
            return res;
        }
        static double GetDouble(string s)
        {
            bool flag = true;
            double res = 0;
            string input;
            while (flag)
            {
                flag = false;
                Console.WriteLine(s);
                input = Console.ReadLine();
                try
                {
                    res = Convert.ToDouble(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input.Try again.");
                    flag = true;
                }
            }
            return res;
        }
        static void changeInfo(int index)
        {
            Console.WriteLine("Change name:\n");
            string check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].name = Console.ReadLine();
            }
            Console.WriteLine("Change weight:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].weight = GetInt("Weight:\n");
            }
            Console.WriteLine("Change width:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].width = GetDouble("Width:\n");
            }
            Console.WriteLine("Change length:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].length = GetDouble("Length:\n");
            }
            Console.WriteLine("Change max speed:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].maxSpeed = (GetInt("Max speed:\n"));
            }
            Console.WriteLine("Change type:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].type = GetType();
            }
            Console.WriteLine("Change passengers:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].passengers = GetInt("Passengers:\n");
            }
            Console.WriteLine("Change year:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].year = new DateTime(GetInt("Year\n"));
            }
            Console.WriteLine("Change cost:\n");
            check = Console.ReadLine();
            if (check == "y")
            {
                transports[index].cost = GetDouble("Cost:\n");
            }
        }
        static new Transport.typeTransport GetType()
        {
            Console.WriteLine("Choose Type:\n1 air\n2 water\n3 space\n4 land\n");
            int type;
            while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 4)
            {
                Console.WriteLine("ERROR. Try again.");
            }
            switch (type)
            {
                case 1:
                    return Transport.typeTransport.air;
                case 2:
                    return Transport.typeTransport.water;
                case 3:
                    return Transport.typeTransport.space;
                default:
                    return Transport.typeTransport.land;
            }
        }
        static void Main()
        {
            while (true)
            {
                const int numOperations = 4;
                Console.WriteLine("\t\t\tMENU");
                Console.WriteLine("1.Add a new transport");
                Console.WriteLine("2.Delete the transport by index");
                Console.WriteLine("3.Change the information about the transport");
                Console.WriteLine("4.Print list of all transports");
                Console.WriteLine("0.Exit the program\n");
                int type;
                Console.WriteLine("Enter the type of operation:");
                while (!int.TryParse(Console.ReadLine(), out type) || type > numOperations)
                {
                    Console.WriteLine("Wrong input. Try again.");
                    Console.WriteLine("Enter the type of operation:");
                }
                Console.WriteLine();
                switch (type)
                {
                    case 1:
                        Console.Clear();
                        inInfo();
                        Console.WriteLine();
                        break;
                    case 2:
                        if (Transport.countTransport == 0)
                        {
                            Console.WriteLine("The list is empty\n");
                            break;
                        }
                        int index = 0;
                        bool flag = true;
                        while (flag)
                        {
                            index = GetInt("Index:\n");
                            if (index < Transport.countTransport) flag = false;
                        }
                        transports.RemoveAt(index);
                        Transport.countTransport--;
                        Console.Clear();
                        break;
                    case 3:
                        if (Transport.countTransport == 0)
                        {
                            Console.WriteLine("The list is empty.\n");
                            Console.ReadKey();
                            break;
                        }
                        index = 0;
                        flag = true;
                        while (flag)
                        {
                            index = GetInt("Index:\n");
                            if (index < Transport.countTransport) flag = false;
                        }
                        changeInfo(index);
                        Console.WriteLine("The transport has been changed successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        if (Transport.countTransport == 0)
                        {
                            Console.WriteLine("The list is empty.\n");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        transports.ForEach(i => i.outInfo());
                        Console.ReadKey();
                        break;
                    case 0:
                        return;
                }
            }
        }
    }
}