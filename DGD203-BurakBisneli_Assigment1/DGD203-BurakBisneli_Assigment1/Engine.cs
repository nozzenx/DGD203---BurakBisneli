using System;

namespace DGD203_BurakBisneli_Assigment1
{
    public abstract class Engine
    {
        protected int Hp;
        protected int Torque;
        protected int MaxSpeed;
 
        public bool Running {get; private set;}

        protected Engine(int hp, int torque, int maxSpeed)
        {
            Hp = hp;
            Torque = torque;
            MaxSpeed = maxSpeed;
        }

        public void CheckStatus()
        {
            Console.WriteLine("Checking engine...");
            if (Running)
            {
                Console.WriteLine("Engine is ready!");
            }
        }
    
        public void Start()
        {
            Running = true;
        }

        public void Stop()
        {
            Running = false;
        }
    }
}