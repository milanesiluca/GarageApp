using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;


namespace GarageApp.Garages
{
    public class CarGarage: IGarage<Car>
    {
        private Car[] _carPlaces;

        public int NumberOfPlaces { get; private set; }

        public CarGarage(int carPlaces) {
            NumberOfPlaces = carPlaces;
            _carPlaces = new Car[carPlaces];
        }


        public bool AddVehicleToParking(Car v)
        {
            return Utility<Car>.InsertVehicle(v, ref _carPlaces);
        }

        public bool RemoveVehiclefromParking(Car v)
        {
            return Utility<Car>.RemoveVehicle(v, ref _carPlaces);
        }

        public void ShowCarListInGarage() {
            Utility<Car>.ShowVehiclesListInGarage(ref _carPlaces);
        }
    }
}
