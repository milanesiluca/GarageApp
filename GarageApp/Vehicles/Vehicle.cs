using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Vehicles
{

    public abstract class Vehicle
    {
        private string _fuel;
        private int _numberOfSeat;
        private int _lenght;
        public string RegNum { get; private set; }

#pragma warning disable IDE0290
        public Vehicle(string fuel, int seats, int lenght, string regNum)
        {
            _fuel = fuel;
            _numberOfSeat = seats;
            _lenght = lenght;
            RegNum = regNum;
        }
#pragma warning restore IDE0290

        public override string ToString()
        {
            return $"Fuel: {_fuel}\nNumber of seats: {_numberOfSeat}\nLenght: {_lenght}\nReg. Number: {RegNum}\n";
        }
    }
}
