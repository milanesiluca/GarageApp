using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Car : Vehicle
    {
        public int WheelsNumer {  get; private set; }
        public string Color {  get; private set; }

        public Car(string regNumber, int wheels, string fuel, int seats, int lenght, string color): base(fuel, seats, lenght, regNumber)
        {
            WheelsNumer = wheels;
            Color = color;
        }

        public override string ToString()
        {
            return $"Vehicle Class: Car\nColor: {Color}\n" + base.ToString() + "\n";
        }
    }
}
