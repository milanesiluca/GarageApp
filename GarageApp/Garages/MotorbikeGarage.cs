using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace GarageApp.Garages
{
    internal class MotorbikeGarage : IGarage<Motorbike>
    {

        private Motorbike[] _mbPlaces;

        public int NumberOfPlaces { get; private set; }

        public MotorbikeGarage(int mbPlaces)
        {
            NumberOfPlaces = mbPlaces;
            _mbPlaces = new Motorbike[NumberOfPlaces];
        }


        public bool AddVehicleToParking(Motorbike v)
        {
            return Utility<Motorbike>.InsertVehicle(v, ref _mbPlaces);
        }

        public bool RemoveVehiclefromParking(Motorbike v)
        {
            return Utility<Motorbike>.RemoveVehicle(v, ref _mbPlaces);
        }
    }
}
