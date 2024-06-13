using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;


namespace GarageApp.Garages
{
    public class VehiclesGarage: IGarage<Vehicle>
    {
        private Vehicle[] _vehiPlaces;

        public int NumberOfPlaces { get; private set; }

        public VehiclesGarage(int carPlaces) {
            NumberOfPlaces = carPlaces;
            _vehiPlaces = new Vehicle[carPlaces];
        }


        public bool AddVehicleToParking(Vehicle v)
        {
            return Utility<Vehicle>.InsertVehicle(v, ref _vehiPlaces);
        }

        public bool RemoveVehiclefromParking(Vehicle v)
        {
            return Utility<Vehicle>.RemoveVehicle(v, ref _vehiPlaces);
        }

        public void ShowCarListInGarage() {
            Console.Clear();
            Utility<Vehicle>.ShowVehiclesListInGarage(ref _vehiPlaces);
        }
    }
}
