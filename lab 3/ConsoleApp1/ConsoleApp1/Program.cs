using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    public class Transport
    {
        private static int _id;
        public int Id { get; protected set; }
        public string ManufactureCountry { get; protected set; }
        protected double mileAge;
        public double MileAge
        {
            get { return mileAge; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    mileAge = value;
                }
            }
        }
        protected int maxSpeed;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    maxSpeed = value;
                }
            }
        }
        static Transport()
        {
            _id = 0;
        }
        public Transport(double mileAge, int maxSpeed, string country)
        {
            this.MileAge = mileAge;
            this.MaxSpeed = maxSpeed;
            this.ManufactureCountry = country;
            this.Id = ++_id;
        }
        public Transport()
        {
            this.MileAge = 0;
            this.MaxSpeed = 250;
            this.ManufactureCountry = "unknown";
            this.Id = ++_id;
        }
        public Transport(int maxSpeed, string country) : this(0, maxSpeed, country)
        {
        }
        public virtual void Run(double mile)
        {
            MileAge += mile;
        }
        public override string ToString()
        {
            return string.Format("ID : {0}, MILIAGE : {1}, MAXSPEED : {2}, FROM : {3}", Id, MileAge, MaxSpeed, ManufactureCountry);
        }
        class Program
        {
            static void Main(string[] args)
            {
                var list = new List<Transport>
            {
                new Transport(),
                new Transport(32, "Germany"),
                new Transport(1234, 345, "Austria")
            };
                while (true)
                {
                    Console.WriteLine("1.Print all\n" +
                                      "2.Add new transport\n" +
                                      "3.Delete transport by index\n" +
                                      "4.Exit");//menu
                    if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 4)
                    {
                        switch (option)
                        {
                            case 1:
                                {
                                    foreach (var tr in list)
                                    {
                                        Console.WriteLine(tr);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    var strings = Console.ReadLine().Split(' ');
                                    if (strings.Length == 3)
                                    {
                                        try
                                        {
                                            list.Add(new Transport(Convert.ToDouble(strings[0]), Convert.ToInt32(strings[1]), strings[2]));
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                    else if (strings.Length == 2)
                                    {
                                        try
                                        {
                                            list.Add(new Transport(Convert.ToInt32(strings[0]), strings[1]));
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        list.Add(new Transport());
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (int.TryParse(Console.ReadLine(), out int del) && del >= 0 && del <= list.Count)
                                    {
                                        list.RemoveAt(--del);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input\n");
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    return;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input\n");
                        continue;
                    }
                }
            }
        }
    }
}