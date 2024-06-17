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
        public int Height { get; set; }
        public override string ToString()
        {
            return $"Vehicle Class: Buss\nHeight: {Height}\n" + base.ToString() + "\n";
        }
    }
}
