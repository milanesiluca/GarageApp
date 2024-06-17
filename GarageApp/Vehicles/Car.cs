using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Car : Vehicle
    {
        public int Doors { get; set; }

        public override string ToString()
        {
            return $"Vehicle Class: Car\nNumber of Doors: {Doors}\n" + base.ToString() + "\n";
        }
 
    }
}
