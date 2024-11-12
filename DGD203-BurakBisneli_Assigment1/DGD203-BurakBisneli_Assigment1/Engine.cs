namespace DGD203_BurakBisneli_Assigment1
{
    public abstract class Engine
    {
        protected int Hp;
        protected int Torque;
        protected int MaxSpeed;
 
        public bool Running {get; protected set;}

        protected Engine(int hp, int torque, int maxSpeed)
        {
            Hp = hp;
            Torque = torque;
            MaxSpeed = maxSpeed;
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