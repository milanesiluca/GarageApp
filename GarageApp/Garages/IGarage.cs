using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Vehicles;

namespace GarageApp.Garages
{
    internal interface IGarage<T>
    {
        int NumberOfPlaces { get; }

        bool AddVehicleToParking(T v);
        void RemoveVehicleFromGarage(string v);
    }
}
