﻿using GarageApp.ConsoleUI;
using GarageApp.Vehicles;

namespace GarageApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            IPrinter<Vehicle> menuPrinter = new Printer<Vehicle>();
            GarageManager newGarage = new GarageManager(10, printer: menuPrinter);
            newGarage.OpenGarage();
        }
    }
}
