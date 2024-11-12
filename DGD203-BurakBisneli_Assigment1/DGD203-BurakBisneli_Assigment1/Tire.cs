using System;

namespace DGD203_BurakBisneli_Assigment1
{
    public abstract class Tire
    {
        protected int Inch;
        protected int TirePressure;

        protected Tire(int inch, int tirePressure)
        {
            Inch = inch;
            TirePressure = tirePressure;
        }

        public virtual void CheckPressure()
        {
            Console.WriteLine("Checking tire pressure...");
            
            if (TirePressure < 35)
            {
                Console.WriteLine("Tire pressure is too low.");
            }

            else if (TirePressure > 40)
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