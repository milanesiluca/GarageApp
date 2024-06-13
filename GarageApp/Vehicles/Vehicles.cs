using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{
    public abstract class Vehicles
    {
        private string _fuel;
        private int _numberOfSeat;
        private int _lenght;

#pragma warning disable IDE0290
        public Vehicles(string fuel, int seats, int lenght) { 
            _fuel = fuel;
            _numberOfSeat = seats;
            _lenght = lenght;
        }
#pragma warning restore IDE0290

        public override string ToString()
        {
            return $"Fuel: {_fuel}\nNumber of seats: {_numberOfSeat}\nLenght: {_lenght}";
        }
    }
}
