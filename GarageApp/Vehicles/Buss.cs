using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Buss : Vehicle
    {
        public int WheelsNumer { get; private set; }

        public Buss(string regNumber, int wheels, string fuel, int seats, int lenght) : base(fuel, seats, lenght, regNumber)
        {
            WheelsNumer = wheels;
        }

        public override string ToString()
        {
            return $"Vehicle Class: Buss\nWheels: {WheelsNumer}\n" + base.ToString() + "\n";
        }
    }
}
