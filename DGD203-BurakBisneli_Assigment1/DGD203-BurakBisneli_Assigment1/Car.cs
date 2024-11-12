using System;

namespace DGD203_BurakBisneli_Assigment1
{
    public class Car
    {
        private Tire _tire;
        private Engine _engine;

        protected Car(Engine engine, Tire tire)
        {
            _tire = tire;
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
            CheckEngineStatus();
        }

        private void CheckEngineStatus()
        {
            Console.WriteLine("Checking engine...");
            if (_engine.Running)
            {
                Console.WriteLine("Engine is ready!");
            }
        }
    }
}