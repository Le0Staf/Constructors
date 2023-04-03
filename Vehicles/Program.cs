using System;
using Vehicles;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck1 = new Truck(500, "red", "Volvo");

            Console.WriteLine("\nbrand:" + truck1.brand + "\ncolor:" + truck1.color + "\ncargo volume: " + truck1.cargo_volume + " kg");


            PassangerCar car1 = new PassangerCar(100, "red", "Opel");

            Console.WriteLine("\nbrand:" + car1.brand + "\ncolor:" + car1.color + "\ncargo volume: " + car1.trunk_volume + " kg");
            Console.ReadLine();
        }

        
    }
}