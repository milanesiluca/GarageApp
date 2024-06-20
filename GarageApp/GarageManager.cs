using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GarageApp.ConsoleUI;
using GarageApp.Garages;
using GarageApp.Vehicles;
using UtilityLibrary;

[assembly: InternalsVisibleTo("GarageTest")]
namespace GarageApp
{
    internal class GarageManager
    {
        public int VehiclesParkPlaces { get; private set; }

        private VehiclesGarage ZioPinoGarage;
        //private Vehicle? newVeh;

        private IPrinter<Vehicle> _printer;
        private IUIInput _uIInput;

        public GarageManager(int vhParkPalces, IPrinter<Vehicle> printer, IUIInput uIInput) {

            VehiclesParkPlaces = vhParkPalces;
            
            ZioPinoGarage = new VehiclesGarage(VehiclesParkPlaces);

            _printer = printer;
            _uIInput = uIInput;
            

        }

        public void OpenGarage() {
            int operation = -1;
            do {
                _printer.PrintMainMenu();

                string? chosenOperation = Console.ReadLine();

                operation = Utility<Vehicle>.ValidateInsertion(chosenOperation!);

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
                    case 5:
                        ZioPinoGarage.FilterVehicleByFeature();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Option Not Available\n");
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
            Type? vhType;

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
                case 0:
                case -1:
                    Console.Clear();
                    vhType = null;
                    break;
                default:
                    vhType = null;
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
            
                
            
        }

        
        private void VehicleEntranceRegistration() {

            int operation = -1;
            Vehicle? vhEnt = null;
            do {
                _printer.PrintCategoryMenu();
                string? chosenOperation = Console.ReadLine();
                operation = Utility<Vehicle>.ValidateInsertion(chosenOperation!);

                switch (operation)
                {

                    case 1:
                        vhEnt = new Car();
                        break;
                    case 2:
                        vhEnt = new Motorbike();
                        break;
                    case 3:
                        vhEnt = new Buss();
                        break;
                    case 0:
                        Console.Clear();
                        vhEnt = null;
                        break;
                    default :
                        Console.WriteLine("Insert an available option, please");
                        break;
                }

                bool success = false;
                if (vhEnt != null) 
                    success = _uIInput.setVehicleDetails(ref vhEnt, false);

                if (success)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    
                    Vehicle? alreadyInGarage = ZioPinoGarage.FilterVehicleListByRegNumber(vhEnt?.RegNum!);
                    if (alreadyInGarage != null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Vehicle with this reg. number is alredy in garage");
                        Console.ResetColor();
                        return;
;                   }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(ZioPinoGarage.AddVehicleToParking(vhEnt!) ? " * Veichle added correctly * \n" : " * En error has occoured * \n");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while(operation != 0);

        }

        
    }
}
