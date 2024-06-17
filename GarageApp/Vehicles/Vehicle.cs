using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{

    public class Vehicle 
    {
        public string? Fuel { get; set; }
        public int NumberOfSeat { get; set; }
        public int Lenght { get; set; }
        public string? RegNum { get; set; }
        public int WheelsNumer { get; set; }
        public string? Color { get; set; }

        private int _numberOfSeats;
        private int _lenght;

        public override string ToString()
        {
            return $"Color: {Color}\nFuel: {Fuel}\nNumber of seats: {NumberOfSeat}\nLenght: {Lenght}\nReg. Number: {RegNum}\nNumber Of Wheels: {WheelsNumer}\n";
        }
    }
}
