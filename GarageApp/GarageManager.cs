﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.ConsoleUI;
using GarageApp.Garages;
using GarageApp.Vehicles;
using UtilityLibrary;

namespace GarageApp
{
    internal class GarageManager
    {
        public int VehiclesParkPlaces { get; private set; }

        private VehiclesGarage ZioPinoGarage;
        private Vehicle? newVeh;

        private IPrinter<Vehicle> _printer;

        public GarageManager(int vhParkPalces, IPrinter<Vehicle> printer) {

            VehiclesParkPlaces = vhParkPalces;
            
            ZioPinoGarage = new VehiclesGarage(VehiclesParkPlaces);

            _printer = printer;
            

        }

        public void OpenGarage() {
            int operation = -1;
            do {
                _printer.PrintMainMenu();

                string? chosenOperation = Console.ReadLine();

                try { 
                    operation = int.Parse(chosenOperation!);
                
                } catch {
                    Console.WriteLine("Invalid input. Try again");
                }

                switch (operation)
                {
                    case 1:
                        VehicleEntranceRegistration();
                        break;
                    case 2:
                        VehicleExitRegistration();
                        break;
                    case 3:
                        ZioPinoGarage.ShowCarListInGarage();
                        break;
                    case 4:
                        FilterVehiclesByType();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid option.Please try again");
                        break;
                }

            } while(operation != 0);
        
        }

        private void VehicleExitRegistration()
        {

            Console.Write("Insert the Vehicle's Reg. Number: ");
            var regNummer = Console.ReadLine();
            if (string.IsNullOrEmpty(regNummer)) { 
                Console.WriteLine("Empty Reg. Nummer");
                return;
            }

            ZioPinoGarage.RemoveVehicleFromGarage(regNummer);
            
        }

        private void FilterVehiclesByType() {
            _printer.PrintCategoryMenu();
            int operation = -1;
            string? chosenOperation = Console.ReadLine();
            Type? vhType = null;

            operation = Utility<Vehicle>.ValidateInsertion(chosenOperation!);
            switch (operation)
            {
                case 1:
                    vhType = typeof(Car);
                    break;
                case 2:
                    vhType = typeof(Motorbike);
                    break;
                case 3:
                    vhType = typeof(Buss);
                    break;
                case -1:
                    vhType = null;
                    break;
                default:
                    vhType = null;
                    Console.WriteLine("En error has occured");
                    break;
            }

            IEnumerable<Vehicle>? filteredVehiclesList = null;
            if (vhType != null)
            {
                filteredVehiclesList = ZioPinoGarage.FilterVehicleListByType(vhType);
                if (filteredVehiclesList?.Count() == 0) {
                    Console.WriteLine($"No Vehicle of {vhType?.Name!} parked in garage\n");
                    return;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($" * {filteredVehiclesList?.Count()} {vhType?.Name!} parked in garage * \n");
                Console.ResetColor();
                foreach (var vhh in filteredVehiclesList!)
                {
                    Console.WriteLine(vhh.ToString());
                }
            }
            else
                Console.WriteLine($"En Error has occured");
                
            
        }


        //ToDo: temporary to get populate the array for the test
        private void VehicleEntranceRegistration() {

            int operation = -1;
            Vehicle? vhEnt = null;
            do {
                _printer.PrintCategoryMenu();
                string? chosenOperation = Console.ReadLine();
                try
                {
                    operation = int.Parse(chosenOperation!);
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again");
                }

                switch (operation)
                {

                    case 1:
                        vhEnt = new Car("ABC123", 4, "gasoline", 5, 450, "red");
                        break;
                    case 2:
                        vhEnt = new Motorbike(regNumber: "FF443", wheels: 2, fuel: "gasoline", seats: 2, lenght: 220, color: "blue");
                        break;
                    case 3:
                        vhEnt = new Buss(regNumber: "kke44y", wheels: 6, fuel: "diesel", seats: 89, lenght: 790);
                        break;
                    case 0:
                        vhEnt = null;
                        break;
                    default :
                        Console.WriteLine("Insert an available option, please");
                        break;
                }

                if (vhEnt is not null)
                    Console.WriteLine(ZioPinoGarage.AddVehicleToParking(vhEnt) ? "Veichle added correctly\n":"En error has occoured\n");

            } while(operation != 0);
            

        
        }

        
    }
}
