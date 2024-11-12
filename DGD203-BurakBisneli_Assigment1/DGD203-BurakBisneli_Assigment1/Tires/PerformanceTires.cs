using System;

namespace DGD203_BurakBisneli_Assigment1.Tires
{
    public class PerformanceTires : Tire
    {
        public PerformanceTires(int inch, int tirePressure) : base(inch, tirePressure)
        {
        }

        public override void CheckTirePressure()
        {
            if (TirePressure < 40)
            {
                Console.WriteLine("Tire pressure is too low for performance tires.");
            }

            else if (TirePressure > 45)
            {
                Console.WriteLine("Tire pressure is too high.");
            }

            else
            {
                Console.WriteLine("Tire pressure is good.");
            }
        }
    }
}