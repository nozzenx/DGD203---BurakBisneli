namespace DGD203_BurakBisneli_Assigment1
{
    public class Headlight
    {
        protected string LightColor;
        public bool IsOpen {get; private set;}

        public Headlight(string lightColor)
        {
            LightColor = lightColor;
        }

        public void Open()
        {
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }
    }
}