using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Buss : Vehicles
    {
        public string RegNumber { get; private set; }
        public int WheelsNumer { get; private set; }

        public Buss(string regNumber, int wheels, string fuel, int seats, int lenght) : base(fuel, seats, lenght)
        {
            RegNumber = regNumber;
            WheelsNumer = wheels;
        }
    }
}
