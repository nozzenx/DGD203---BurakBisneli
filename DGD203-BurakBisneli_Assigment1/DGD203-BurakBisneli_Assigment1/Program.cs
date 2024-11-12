using System;
using DGD203_BurakBisneli_Assigment1.Brakes;
using DGD203_BurakBisneli_Assigment1.Engines;
using DGD203_BurakBisneli_Assigment1.Headlights;
using DGD203_BurakBisneli_Assigment1.Tires;

namespace DGD203_BurakBisneli_Assigment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car(new DieselEngine(500, 1200, 300), new HydraulicBrakes(), new PerformanceTires(21, 38), new AdaptiveHeadlights("White"));
            
            Car car2 = new Car(new ElectricEngine(900, 1400, 320), new DiscBrakes(), new TouringTires(22, 39), new LedHeadlights("White"));
            
            Car car3 = new Car(new HybridEngine(150, 550, 190), new HydraulicBrakes(), new SnowTires(19, 43), new XenonHeadlights("Yellow"));
            
            Console.WriteLine("Car 1");
            Console.WriteLine("________________________");
            car1.Start();
            Console.WriteLine("________________________");
            Console.WriteLine("");
            Console.WriteLine("Car 2");
            Console.WriteLine("________________________");
            car2.Start();
            Console.WriteLine("________________________");
            Console.WriteLine("");
            Console.WriteLine("Car 3");
            Console.WriteLine("________________________");
            car3.Start();
            Console.WriteLine("________________________");
            
            
        }
    }
}