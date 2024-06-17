using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public class Motorbike : Vehicle
    {

        public override string ToString()
        {
            return $"Vehicle Class: Motorbike\n" + base.ToString() + "\n";
        }
    }
}
