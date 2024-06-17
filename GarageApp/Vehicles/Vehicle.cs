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
        public string? Fuel { get; set; }
        public int NumberOfSeat { get; set; }
        public int Lenght { get; set; }
        public string? RegNum { get; set; }

        public int WheelsNumer { get; set; }

        private int _numberOfSeats;
        private int _lenght;

#pragma warning disable IDE0290
        //public Vehicle(string fuel, int seats, int lenght, string regNum)
        //{
        //    Fuel = fuel;
        //    NumberOfSeat = seats;
        //    Lenght = lenght;
        //    RegNum = regNum;

        //}

#pragma warning restore IDE0290

        public override string ToString()
        {
            return $"Fuel: {Fuel}\nNumber of seats: {NumberOfSeat}\nLenght: {Lenght}\nReg. Number: {RegNum}\nNumber Of Wheels: {WheelsNumer}\n";
        }
    }
}
