using Praktika16v2.Models;
using System;

namespace Praktika16v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(15);
            bus1.Color = "Black";
            bus1.Year = 2014;
            Car car1 = new Car("Bmw","F10");
            car1.Year = 2014;
            car1.MaxSpeed = 320;
            Vehicle[] vehicles = new Vehicle[0];

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = bus1;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = car1;

            foreach (var item in vehicles)
            {
                item.ShowInfo();
                Console.WriteLine("---------------------------");
            }


        }
        
    }
}
