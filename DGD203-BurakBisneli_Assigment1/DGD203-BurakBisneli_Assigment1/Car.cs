using System;

namespace DGD203_BurakBisneli_Assigment1
{
    public class Car
    {
        private Tire _tire;
        private Engine _engine;
        private  Headlight _headlight;
        private Brake _brake;

        public Car(Engine engine, Brake brake, Tire tire, Headlight headlight)
        {
            _tire = tire;
            _engine = engine;
            _brake = brake;
            _headlight = headlight;
        }

        public void Start()
        {
            Console.WriteLine($"Engine: {_engine.GetType().Name}");
            Console.WriteLine($"Brakes: {_brake.GetType().Name}");
            Console.WriteLine($"Tires: {_tire.GetType().Name}");
            Console.WriteLine($"Headlights: {_headlight.GetType().Name}");
            Console.WriteLine("");
            _engine.Start();
            _engine.CheckStatus();
            Console.WriteLine("");
            _tire.CheckPressure();
        }
        
    }
}