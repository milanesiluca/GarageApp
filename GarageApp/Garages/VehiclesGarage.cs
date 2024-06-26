﻿using GarageApp.ConsoleUI;
using GarageApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

[assembly: InternalsVisibleTo("GarageTest")]
namespace GarageApp.Garages
{
    public class VehiclesGarage: IGarage<Vehicle>
    {
        private Vehicle[] _vehiPlaces;
        public Vehicle[] VehiPlaces { get; private set;  }

        public int NumberOfPlaces { get; private set; }

        public VehiclesGarage(int carPlaces) {
            NumberOfPlaces = carPlaces;
            _vehiPlaces = new Vehicle[carPlaces];
            VehiPlaces = _vehiPlaces;
        }



        public bool AddVehicleToParking(Vehicle v)
        {
            return Utility<Vehicle>.InsertVehicle(v, ref _vehiPlaces);
        }

        public void ShowCarListInGarage() {
            Console.Clear();
            Utility<Vehicle>.ShowVehiclesListInGarage(ref _vehiPlaces);
        }

        public Vehicle? FilterVehicleListByRegNumber(string regNum) {
            
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
            IUIInput input = new UIInput();
            bool success = input.setVehicleDetails(ref genVh, true);
            
            if (success)
            {
                var result = EnumarebleLINQClass.getbackFilteredList(_vehiPlaces, genVh);

                if (result != null && result.Count() > 0)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($" * Filter result: {result.Count()} vehicles * ");
                    Console.ResetColor();
                    Console.WriteLine();
                    foreach (Vehicle item in result)
                        Console.WriteLine(item.ToString());
                }
                else
                    Console.WriteLine("\nNo Result for your search\n");
                
            } else
                Console.WriteLine("\nEn Error has occoured\n");

        }

             
        public void RemoveVehicleFromGarage(string regNum) {
            var vehicleToRemove = FilterVehicleListByRegNumber(regNum);
            if (vehicleToRemove == null) {
                Console.WriteLine("Vehicle not parked in garage");
                return;
            }

            Console.WriteLine(Utility<Vehicle>.RemoveVehicle(vehicleToRemove, ref _vehiPlaces) ? "Vehicle exit registered": "En Error has occoured");
            
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach (Vehicle vh in _vehiPlaces)
                yield return vh;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
    }
}
