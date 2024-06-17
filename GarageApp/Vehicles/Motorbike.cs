using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Motorbike : Vehicle
    {
        public string? Color { get; set; }

  

        public override string ToString()
        {
            return $"Vehicle Class: Motorbike\nColor: {Color}\n" + base.ToString() + "\n";
        }
    }
}
