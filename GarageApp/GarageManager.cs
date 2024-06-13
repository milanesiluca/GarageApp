using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.ConsoleUI;
using GarageApp.Garages;
using GarageApp.Vehicles;

namespace GarageApp
{
    internal class GarageManager
    {
        public int VehiclesParkPlaces { get; private set; }

        private VehiclesGarage ZioPinoGarage;
        private Vehicle? newVeh;

        public GarageManager(int vhParkPalces) {

            VehiclesParkPlaces = vhParkPalces;
            
            ZioPinoGarage = new VehiclesGarage(VehiclesParkPlaces);
            

        }

        public void OpenGarage() {
            int operation = -1;
            do {
                Printer<Vehicle>.PrintMainMenu();

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
                        break;
                    case 3:
                        ZioPinoGarage.ShowCarListInGarage();
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

        private void VehicleEntranceRegistration() {

            int operation = -1;
            Vehicle? vhEnt = null;
            do {
                Printer<Vehicle>.PrintCategoryMenu();
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
                    Console.WriteLine(ZioPinoGarage.AddVehicleToParking(vhEnt) ? "Veichle added correctly":"En error has occoured");

            } while(operation != 0);
            

        
        }

        private void ManageCar()
        {
            int operation = -1;
            do {

                
                string? chosenOperation = Console.ReadLine();
                try
                {
                    
                    operation = int.Parse(chosenOperation!);
                    switch (operation)
                    {
                        case 1:
                            newVeh = new Car("ABC123", 4, "gasoline", 5, 450, "red");
                            Console.WriteLine(ZioPinoGarage.AddVehicleToParking(newVeh) ? "Car added correctly" : "Operation Failed");
                            break;
                        case 2:
                            break;
                        case 3:
                            ZioPinoGarage.ShowCarListInGarage();
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            } while (operation != 0);
        }
    }
}
