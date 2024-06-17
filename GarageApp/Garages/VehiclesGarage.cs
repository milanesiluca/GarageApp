using GarageApp.ConsoleUI;
using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

        private bool RemoveVehiclefromParking(Vehicle v)
        {
            return Utility<Vehicle>.RemoveVehicle(v, ref _vehiPlaces);
        }

        public void ShowCarListInGarage() {
            Console.Clear();
            Utility<Vehicle>.ShowVehiclesListInGarage(ref _vehiPlaces);
        }

        private Vehicle? FilterVehicleListByRegNumber(string regNum) {
            
            var filteredList = _vehiPlaces
                               .Where(vh => vh != null)
                               .Where(vh => vh.RegNum!.ToLower()!.Equals(regNum!.ToLower())).ToList();
            return filteredList.FirstOrDefault();

        }

        public IEnumerable<Vehicle>? FilterVehicleListByType(Type vhType)
        {

            var filteredList = _vehiPlaces
                               .Where(vh => vh != null)
                               .Where(vh => vh.GetType().Equals(vhType)).ToList();
            return filteredList!;

        }

        public void FilterVehicleByFeature() { 

            Vehicle genVh = new Vehicle();
            UIInput input = new UIInput();
            bool success = input.setVehicleDetails(ref genVh, true);
            IEnumerable<Vehicle>? vhFilteredList = null;
            if (success)
            {

                /*
                 placeList = placeList
                            .Where(vv => vv != null)
                            .Where(vh => !vh!.Equals(vehicle)).ToArray();
                 
                 */

                
                

                if (vhFilteredList != null && vhFilteredList.Count() > 0)
                {
                    foreach (Vehicle vh in vhFilteredList) 
                        vh.ToString();
                }
            }
            
        
        }

        public void RemoveVehicleFromGarage(string regNum) {
            var vehicleToRemove = FilterVehicleListByRegNumber(regNum);
            if (vehicleToRemove == null) {
                Console.WriteLine("Vehicle not parked in garage");
                return;
            }

            Console.WriteLine(Utility<Vehicle>.RemoveVehicle(vehicleToRemove, ref _vehiPlaces) ? "Vehicle exit registered": "En Error has occoured");
            
        }
    }
}
