using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Motorbike : Vehicle
    {
        public string RegNumber { get; private set; }
        public int WheelsNumer { get; private set; }
        public string Color { get; private set; }

        public Motorbike(string regNumber, int wheels, string fuel, int seats, int lenght, string color) : base(fuel, seats, lenght)
        {
            RegNumber = regNumber;
            WheelsNumer = wheels;
            Color = color;
        }

        public override string ToString()
        {
            return $"Vehicle Class: Motorbike\nReg. Number: {RegNumber}\nColor: {Color}\nWheels Number: {WheelsNumer}\n" + base.ToString() + "\n";
        }
    }
}
