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
        public int CarParkPlaces { get; private set; }
        public int BussTirParkPlaces { get; private set; }
        public int MbikeParkPlaces { get; private set; }

        private CarGarage ZioPinoGarage;


        public GarageManager(int carParkPalces, int bussParkPlaces, int mbikeParkPlaces) { 

            CarParkPlaces = carParkPalces;
            BussTirParkPlaces = bussParkPlaces;
            MbikeParkPlaces = mbikeParkPlaces;
            //ToDo: add other array to complete the parking place categotry
            ZioPinoGarage = new CarGarage(carParkPalces);

        }

        public void OpenGarage() {
            int operation = -1;
            do {
                Console.WriteLine("Chose the operation to test\n");
                Console.WriteLine("1- Cars");
                Console.WriteLine("2- Bus / Truck");
                Console.WriteLine("3- Motorbike");
                Console.WriteLine("0- Close Garage");
                Console.WriteLine();
                Console.Write("Insert the chosen option: ");

                string? chosenOperation = Console.ReadLine();

                try { 
                    operation = int.Parse(chosenOperation!);
                
                } catch {
                    Console.WriteLine("Invalid input. Try again");
                }

                switch (operation)
                {
                    case 1:
                        ManageCar();
                        break;
                    case 2:
                        break;
                    case 3:
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

        private void ManageCar()
        {
            int operation = -1;
            do {

                Printer<Car>.PrintMenu();
                string? chosenOperation = Console.ReadLine();
                try
                {
                    operation = int.Parse(chosenOperation!);
                    switch (operation)
                    {
                        case 1:
                            Car newCar = new Car("ABC123", 4, "benzin", 5, 450, "red");
                            ZioPinoGarage.AddVehicleToParking(newCar);
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
