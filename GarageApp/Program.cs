namespace GarageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageManager newGarage = new GarageManager(10);
            newGarage.OpenGarage();
        }
    }
}
