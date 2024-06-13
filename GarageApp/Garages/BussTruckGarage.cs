using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace GarageApp.Garages
{
    internal class BussTruckGarage : IGarage<Buss>
    {
        private Buss[] _bussPlaces;
        public int NumberOfPlaces { get; private set; }

        public BussTruckGarage(int bussPlace) { 
            NumberOfPlaces = bussPlace;
            _bussPlaces = new Buss[NumberOfPlaces];
        }

        public bool AddVehicleToParking(Buss v)
        {
            return Utility<Buss>.InsertVehicle(v, ref _bussPlaces);
        }

        public bool RemoveVehiclefromParking(Buss v)
        {
            return Utility<Buss>.InsertVehicle(v, ref _bussPlaces);
        }
    }
}
