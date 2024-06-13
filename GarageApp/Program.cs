namespace GarageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageManager newGarage = new GarageManager(carParkPalces: 10, bussParkPlaces: 5, mbikeParkPlaces: 20);
            newGarage.OpenGarage();
        }
    }
}
