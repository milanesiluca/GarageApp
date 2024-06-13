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
            int carInPark = _carPlaces.Count(vv => vv != null);
            Console.WriteLine($"\nCars parked in garage: {carInPark}");
            for (int i = 0; i< carInPark; i++) { 
                var car = _carPlaces[i];
                if (car != null) { 
                    Console.WriteLine(car.ToString());
                }
            }
        }
    }
}
